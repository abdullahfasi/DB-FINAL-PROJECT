using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.LogInSignUp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void CreateAccount()
        {
            string Fname = firstname.Text;
            string lname = lastname.Text;
            string email = stemail.Text;
            string password = upassword.Text;
            string repass = ReenterPass.Text;
            string contact = ucontact.Text;
            string city = ucity.Text;
            string regno = uregno.Text;
            string department = stdepartment.Text;
            int ssemester = int.Parse(stsemester.Text);
            long cnic;
            string usertype = "Student";
            string emailPattern = @"^\S+@gmail\.com";
            string registrationPattern = @"^20\d{2}-[A-Z]{2}-.+$";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repass) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(regno) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(stsemester.Text) || string.IsNullOrEmpty(ucnic.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if (!int.TryParse(stsemester.Text, out ssemester))
            {
                MessageBox.Show("Invalid semester value. Please enter a valid integer value.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(stemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else if (!long.TryParse(ucnic.Text, out cnic) || ucnic.Text.Length != 13 || !long.TryParse(ucnic.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 14-digit CNIC number.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(uregno.Text, registrationPattern))
            {
                MessageBox.Show("Please enter a valid Registration Number in the format 20XX-YY-XX.");
                return;
            }
            else if (contact.Length != 11 || !contact.StartsWith("03"))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 11-digit contact number starting with '03'.");
            }
            else if (password != repass)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long.");
            }
            else if (!termAcceptCheckbox.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions before proceeding.");
            }
            else
            {
                BL.Student student = new BL.Student(Fname,lname,email,password,contact,cnic,city,usertype, regno,department,ssemester,1,date);
                student.SignUp();
                firstname.Clear();
                lastname.Clear();
                stemail.Clear();
                upassword.Clear();
                ReenterPass.Clear();
                ucontact.Clear();
                ucity.Clear();
                uregno.Clear();
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignIn login = new SignIn();
            this.Hide();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
