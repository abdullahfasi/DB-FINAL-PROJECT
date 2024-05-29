using DBMidProject;
using FinalProjectDB1.Forms.LogInSignUp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FinalProjectDB1.BL
{
    internal class Student : User
    {
        public string RegistrationNo { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public int Status { get; set; }

        public int UserID { get; set; }
        public DateTime StudentShip_StartDate { get; set; }

        public Student() : base()
        {

        }
        public Student(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            RegistrationNo = registrationNo;
            Department = department;
            Semester = semester;
            Status = status;
            StudentShip_StartDate = studentShip_StartDate;
        }
        public Student(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate, int userid)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            RegistrationNo = registrationNo;
            Department = department;
            Semester = semester;
            Status = status;
            StudentShip_StartDate = studentShip_StartDate;
            UserID = userid;
        }

        public void SignUp()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SignUpProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@StudentShip_StartDate", StudentShip_StartDate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student signed up successfully");
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public string signIn(string email, string password)
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string query = "SELECT * FROM Authentication AS a JOIN [User] AS u ON u.UserID = a.UserID WHERE Email = @Email AND Password = @Password AND LEFT(u.FirstName,1) <> '-'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Check if a row was returned
                    {
                        string userType = reader["UserType"].ToString();
                        int userid = (int)reader["UserID"];
                        return userType;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return null;
        }

        public void AddStudentInDatabase()
        {
            SqlTransaction transaction = null;

            try
            {

                var con = Configuration.getInstance().getConnection();
                transaction = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("AddStudent", con, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@StudentShip_StartDate", StudentShip_StartDate);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Student Added successfully");

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void UpdateStudentInDatabase()
        {




            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UpdateStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@CNIC", CNIC);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@UserType", UserType);
            cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
            cmd.Parameters.AddWithValue("@Department", Department);
            cmd.Parameters.AddWithValue("@Semester", Semester);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@StudentShip_StartDate", StudentShip_StartDate);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Updated successfully");




        }

        public void RemoveStudentFromDatabase()
        {


            MessageBox.Show(UserID.ToString());
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update [User] Set FirstName = CONCAT('-',FirstName) WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }
    }
}
