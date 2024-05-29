using DBMidProject;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using FinalProjectDB1.BL;

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeleteAdmin : Form
    {
        string ufname;
        string ulname;
        string ccontact;
        long ccnic;
        string uemail;
        string udesignation;
        float usalary;
        string upass;
        public DeleteAdmin()
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


            else if (!System.Text.RegularExpressions.Regex.IsMatch(stemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long.");
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
                // bool exist = alreadyExist();
                // if (!exist)
                // {
                int id = findID();
                Admin admin = new Admin(Fname, lname, email, password, contact, cnic, city, usertype, 0, id);
                admin.DeleteAdmin();
                ShowAdmin();
                clear();
                // }
                // else
                // {
                //     MessageBox.Show("Admin Already Exist");
                // }

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

                    ufname = firstname.Text;
                    ulname = lastname.Text;
                    uemail = stemail.Text;
                    upass = upassword.Text;
                    ccnic = long.Parse(ucnic.Text);
                    ccontact = ucontact.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT [User].UserID From [User] JOIN Authentication as a on a.UserID = [User].UserID WHERE FirstName = @FirstName AND LastName = @LastName AND a.Email = @Email AND Contact = @Contact AND CNIC = @CNIC AND a.Password = @Password", con);
                cmd.Parameters.AddWithValue("@FirstName", ufname);
                cmd.Parameters.AddWithValue("@LastName", ulname);
                cmd.Parameters.AddWithValue("@Contact", ccontact);
                cmd.Parameters.AddWithValue("@Email", uemail);
                cmd.Parameters.AddWithValue("@CNIC", ccnic);
                cmd.Parameters.AddWithValue("@Password", upass);
                id = (int)cmd.ExecuteScalar();
                MessageBox.Show(id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }
    }
}
