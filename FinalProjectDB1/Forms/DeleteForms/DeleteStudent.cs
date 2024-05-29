﻿using DBMidProject;
using FinalProjectDB1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeleteStudent : Form
    {
        int activeStatus;
        string sfname;
        string slname;
        string sreg;
        string semailid;
        string scon;
        string scit;
        string sdep;
        long scni;
        string pass;
        int ssemester;
        int activestatus2;
        public DeleteStudent()
        {
            InitializeComponent();
            ShowStudent();
        }

       
        private void royalButton1_Click(object sender, EventArgs e)
        {
            string Fname = firstname.Text;
            string lname = lastname.Text;
            string email = stemail.Text;
            string password = upassword.Text;
            string contact = ucontact.Text;
            string city = ucity.Text;
            string regno = uregno.Text;
            string department = stdepart.Text;
            int semester = int.Parse(stsemester.Text);
            long cnic;
            string emailPattern = @"^\S+@gmail\.com";
            string registrationPattern = @"^20\d{2}-[A-Z]{2}-.+$";
            string status = astatus.Text;
            if (status == "Active")
            {
                activeStatus = 1;
            }
            else if (status == "InActive")
            {
                activeStatus = 2;
            }
            string usertype = "Student";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(regno) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(stsemester.Text) || string.IsNullOrEmpty(ucnic.Text) || string.IsNullOrEmpty(astatus.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if (!int.TryParse(stsemester.Text, out semester))
            {
                MessageBox.Show("Invalid semester value. Please enter a valid integer value.");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(uregno.Text, registrationPattern))
            {
                MessageBox.Show("Please enter a valid Registration Number in the format 20XX-YY-XX.");
                return;
             
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
                int id = findID();
                Admin admin = new Admin();
                admin.DeleteStudent(Fname, lname, email, password, contact, cnic, city, usertype, regno, department, semester, activeStatus, date, id);
                ShowStudent();
                clear();

            }


        }
        public void clear()
        {
            firstname.Clear();
            lastname.Clear();
            stemail.Clear();
            upassword.Clear();
            ucontact.Clear();
            ucity.Clear();
            uregno.Clear();
            ucnic.Clear();
            uregno.Clear();
        }

        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT [User].UserID From [User] JOIN Authentication as a ON [User].UserID = a.UserID WHERE FirstName = @FirstName AND LastName = @LastName AND a.Email = @Email AND Contact = @Contact AND CNIC = @CNIC AND a.Password = @Password", con);
                cmd.Parameters.AddWithValue("@FirstName", sfname);
                cmd.Parameters.AddWithValue("@LastName", slname);
                cmd.Parameters.AddWithValue("@Contact", scon);
                cmd.Parameters.AddWithValue("@Email", semailid);
                cmd.Parameters.AddWithValue("@CNIC", scni);
                cmd.Parameters.AddWithValue("@Password", pass);
                id = (int)cmd.ExecuteScalar();
                MessageBox.Show(id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private void ShowStudent()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select s.RegistrationNo, u.FirstName, u.LastName,a.Email,a.Password, u.Contact,s.Department,s.Semester,u.CNIC, CASE WHEN Status = 1 THEN 'Active' WHEN Status = 2 THEN 'InActive' END AS Status,u.City, StudentShip_StartDate from student as s JOIN [user] as u on s.UserID = u.UserID JOIN Authentication AS a ON  u.UserID = a.UserID WHERE LEFT(u.FirstName,1) <> '-' ", con);
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
                    uregno.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    lastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    stemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    upassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    ucontact.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
                    stdepart.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    stsemester.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    ucnic.Text = dataGridView1.SelectedRows[0].Cells[8].Value?.ToString();
                    ucity.Text = dataGridView1.SelectedRows[0].Cells[10].Value?.ToString();
                    astatus.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                    sreg = uregno.Text;
                    sfname = firstname.Text;
                    slname = lastname.Text;
                    semailid = stemail.Text;
                    pass = upassword.Text;
                    scon = ucontact.Text;
                    sdep = stdepart.Text;
                    ssemester = int.Parse(stsemester.Text);
                    scni = long.Parse(ucnic.Text);
                    if (astatus.Text == "Active")
                    {
                        activestatus2 = 1;
                    }
                    else if (astatus.Text == "InActive")
                    {
                        activestatus2 = 2;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
