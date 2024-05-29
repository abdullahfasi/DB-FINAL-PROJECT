using DBMidProject;
using FinalProjectDB1.BL;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectDB1.Forms.UpdateForms
{
    public partial class UpdateAuthor : Form
    {
        string firstname;
        string lastname;
        string nationality;
        DateTime dateOFB;
        long CNIC;
        public UpdateAuthor()
        {
            InitializeComponent();
            ShowAuthors();
        }

        private void dungeonTextBox2_TextChanged(object sender, EventArgs e)
        {


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

            
        }

        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT AuthorID FROM Author WHERE  FirstName = @FirstName AND LastName = @LastName AND Nationality = @Nationality AND DateOfBirth = @DateOfBirth AND CNIC = @CNIC", con);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Nationality", nationality);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOFB);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }
        private void clear()
        {
            fname.Text = "";
            lname.Text = "";
            auNationality.Text = "";
            cnic.Text = "";

        }
        private void royalButton1_Click(object sender, EventArgs e)
        {
            long CNIC;
            string firstname = fname.Text;
            string lastname = lname.Text;
            string nationality = auNationality.Text;
            DateTime dateofbirth = date.Value;
            if (string.IsNullOrEmpty(fname.Text) || string.IsNullOrEmpty(lname.Text) || string.IsNullOrEmpty(auNationality.Text))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else if (!long.TryParse(cnic.Text, out CNIC) || cnic.Text.Length != 13 || !long.TryParse(cnic.Text, out CNIC))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 13-digit CNIC number.");
            }
            else
            {

                int id = findID();
                MessageBox.Show(id.ToString());
                BL.Admin admin = new BL.Admin();
                admin.UpdateAuthor(firstname, lastname, id, dateofbirth, nationality, 1, CNIC);
                ShowAuthors();
                clear();
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

                    firstname = fname.Text;
                    lastname = lname.Text;
                    nationality = auNationality.Text;
                    dateOFB = date.Value;
                    CNIC = long.Parse(cnic.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
