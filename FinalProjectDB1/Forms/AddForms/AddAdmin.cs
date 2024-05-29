using DBMidProject;
using FinalProjectDB1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
            ShowAdmin();
        }
        private void clear()
        {
            firstname.Clear();
            lastname.Clear();
            stemail.Clear();
            upassword.Clear();
            ucontact.Clear();
            ucity.Clear();
            ucnic.Clear();
        }
        private void royalButton1_Click(object sender, EventArgs e)
        {
            string Fname = firstname.Text;
            string lname = lastname.Text;
            string email = stemail.Text;
            string password = upassword.Text;
            string contact = ucontact.Text;
            string city = ucity.Text;
            long cnic;
            string emailPattern = @"^\S+@gmail\.com";
            string registrationPattern = @"^20\d{2}-[A-Z]{2}-.+$";

            string usertype = "Admin";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(ucnic.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if (password.Length < 8) 
            {
                MessageBox.Show("Password must be 8 characters long.");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(stemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else if (contact.Length != 11 || !contact.StartsWith("03"))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 11-digit contact number starting with '03'.");
            }
            else if (!long.TryParse(ucnic.Text, out cnic) || ucnic.Text.Length != 13 || !long.TryParse(ucnic.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 13-digit CNIC number.");
            }
            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    Admin admin = new Admin(Fname, lname, email, password, contact, cnic, city, usertype,1);
                    admin.AddAdmin();
                    ShowAdmin();
                    clear();
                }
                else
                {
                    MessageBox.Show("Admin Already Exist");
                }

            }
        }
        private void ShowAdmin()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AdminView", con);
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
        private bool alreadyExist()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] JOIN Authentication as a ON a.UserID = [User].UserID  WHERE Contact = @Contact OR a.Email = @Email OR CNIC = @CNIC", con);
            cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
            cmd.Parameters.AddWithValue("@LastName", lastname.Text);
            cmd.Parameters.AddWithValue("@Contact", ucontact.Text);
            cmd.Parameters.AddWithValue("@Email", stemail.Text);
            cmd.Parameters.AddWithValue("@CNIC", ucnic.Text);
            cmd.Parameters.AddWithValue("@Password", upassword.Text);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    firstname.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    lastname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    stemail.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    upassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    ucontact.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    ucnic.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
                    ucity.Text = dataGridView1.SelectedRows[0].Cells[6].Value?.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
