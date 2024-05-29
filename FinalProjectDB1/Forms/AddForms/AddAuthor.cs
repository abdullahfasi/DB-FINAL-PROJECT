using DBMidProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;
using System.Web.Mail;
using System.Web.UI.WebControls;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddAuthor : Form
    {
        public int AdminID;
        public AddAuthor(int adminuserid)
        {
            InitializeComponent();
            AdminID = adminuserid;
            label4.Text = AdminID.ToString();

            ShowAuthors();
        }
        private void clear()
        {
            fname.Text = "";
            lname.Text = "";
            auNationality.Text = "";
            cnic.Text = "";
        }

        private bool alreadyExist()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Author WHERE CNIC = @CNIC", con);

            cmd.Parameters.AddWithValue("@CNIC", cnic.Text);

            int id = (int)cmd.ExecuteScalar();
            MessageBox.Show(id.ToString());
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void royalButton1_Click(object sender, EventArgs e)
        {
            string firstname = fname.Text;
            string lastname = lname.Text;
            string nationality = auNationality.Text;
            DateTime dateofbirth = date.Value;
            long CNIC;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(nationality) || string.IsNullOrEmpty(cnic.Text))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else if (!long.TryParse(cnic.Text, out CNIC) || cnic.Text.Length != 13 || !long.TryParse(cnic.Text, out CNIC))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 13-digit CNIC number.");
            }
            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    BL.Admin admin = new BL.Admin();
                    admin.AddAuthor(firstname, lastname, AdminID, dateofbirth, nationality, 1, CNIC);
                    ShowAuthors();
                    clear();
                }
                else
                {
                    MessageBox.Show("Already Exist");
                }
            }


        }

        private void ShowAuthors()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ActiveAuthors ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    fname.Text = row.Cells["FirstName"].Value?.ToString();
                    lname.Text = row.Cells["LastName"].Value?.ToString();
                    auNationality.Text = row.Cells["Nationality"].Value?.ToString();
                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dateValue))
                    {
                        date.Value = dateValue;
                    }
                    cnic.Text = row.Cells["CNIC"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    fname.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    lname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    auNationality.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    date.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    cnic.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void auNationality_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
