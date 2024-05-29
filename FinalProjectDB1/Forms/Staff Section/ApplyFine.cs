using DBMidProject;
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

namespace FinalProjectDB1.Forms.Staff_Section
{
    public partial class ApplyFine : Form
    {
        int edition;
        public ApplyFine()
        {
            InitializeComponent();
            ShowStudentForFine();
            DueFineStudents();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBookRequest_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private int check(int studentid)
        {
            int count = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();
                string query = "SELECT COUNT(*) FROM FineDue WHERE StudentID = @studentid AND Status = 'Unpayed'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentid", studentid);
                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return count;


        }


        private void royalButton1_Click(object sender, EventArgs e)
        {
            string bookIdentifier = booktextbox.Text;
            int bookID = getBookID(bookIdentifier);
            string studentidentifier = studenttextbox.Text;
            int studentID = getStudentID(studentidentifier);
            int issueid = getIssueID(bookID, studentID);
            if (string.IsNullOrEmpty(booktextbox.Text) || string.IsNullOrEmpty(studenttextbox.Text) || string.IsNullOrEmpty(amountpay.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            float amount = float.Parse(amountpay.Text);
            if (amount < 0)
            {
                MessageBox.Show("Please enter valid amount");
                return;
            }
            int checking = check(studentID);
            if (checking > 0)
            {
                MessageBox.Show("Fine has been applied for this student.");
                booktextbox.Clear();
                amountpay.Clear();
                studenttextbox.Clear();
                return;
            }
            else
            {
                try
                {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert INTO FineDue Values (@IssueID,@StudentID,@Date,@Amount,@Status)", con);
                cmd.Parameters.AddWithValue("@IssueID", issueid);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Status", "Unpayed");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fine due Successfully");
                ShowStudentForFine();
                DueFineStudents();
                SqlCommand cmd2 = new SqlCommand("UPDATE Student SET Status = 2 Where UserID = @StudentID",con);
                cmd2.Parameters.AddWithValue("@StudentID", studentID);
                cmd2.ExecuteNonQuery();
                booktextbox.Clear();
                amountpay.Clear();
                studenttextbox.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void ShowStudentForFine()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo, b.BookTitle, b.BookEdition, brs.Status, brs.RequestID FROM BookRequest br INNER JOIN Student s ON br.UserID = s.UserID INNER JOIN Book b ON br.BookID = b.BookID INNER JOIN BookRequestStatus brs ON br.RequestID = brs.RequestID JOIN BookIssue bi ON bi.StudentID = s.UserID WHERE brs.Status = 'Issued' AND bi.ReturnDate < @date", con);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datafromrequesttable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DueFineStudents()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DueFineStudentsView", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                finegrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datafromrequesttable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datafromrequesttable.SelectedRows.Count > 0)
                {
                    studenttextbox.Text = datafromrequesttable.SelectedRows[0].Cells[0].Value?.ToString();
                    booktextbox.Text = datafromrequesttable.SelectedRows[0].Cells[1].Value?.ToString();
                    edition = int.Parse(datafromrequesttable.SelectedRows[0].Cells[2].Value?.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private int getBookID(string bookIdentifier)
        {
            int bookID = -1;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT BookID FROM Book WHERE  BookTitle = @BookIdentifier AND BookEdition = @Edition";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookIdentifier", bookIdentifier);
                cmd.Parameters.AddWithValue("@Edition", edition);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    bookID = Convert.ToInt32(result);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting book ID: " + ex.Message);
            }

            return bookID;
        }

        private int getIssueID(int bookid, int studentid)
        {
            int bookID = -1;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT IssueID FROM BookIssue WHERE  BookID = @BookID AND StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookid);
                cmd.Parameters.AddWithValue("@StudentID", studentid);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    bookID = Convert.ToInt32(result);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting book ID: " + ex.Message);
            }

            return bookID;
        }
        private int getStudentID(string studentidentifier)
        {
            int studentID = -1;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT UserID FROM Student WHERE RegistrationNo = @StudentIdentifier";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentIdentifier", studentidentifier);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    studentID = Convert.ToInt32(result);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting student ID: " + ex.Message);
            }

            return studentID;
        }
    }
}
