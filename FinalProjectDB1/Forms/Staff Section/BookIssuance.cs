using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMidProject;
using FinalProjectDB1.BL;

namespace FinalProjectDB1.Forms.Staff_Section
{
    public partial class BookIssuance : Form
    {
        DateTime issuedate;
        int edition;
        int UserID;
        public BookIssuance(int userid)
        {
            InitializeComponent();
            ShowDatainRequestedTable();
            showissuedbooks(); 
            UserID = userid;
        }

        private void BookIssuance_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            staffid.Text = UserID.ToString();
            showissuedbooks();
            ShowDatainRequestedTable();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {

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

        private void studentdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void royalButton1_Click_1(object sender, EventArgs e)
        {
            string bookIdentifier = booktextbox.Text;
            int bookID = getBookID(bookIdentifier);
            string studentidentifier = studenttextbox.Text;
            int studentID = getStudentID(studentidentifier);

            if (string.IsNullOrEmpty(booktextbox.Text) || string.IsNullOrEmpty(studenttextbox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (bookID == -1)
            {
                MessageBox.Show("Book not found!");
                return;
            }


            if (studentID == -1)
            {
                MessageBox.Show("Please select a student!");
                return;
            }

            bool check = validate();
            if (check)
            {
                try
                {

                    var con = Configuration.getInstance().getConnection();

                    string getRequestIDQuery = "SELECT brs.RequestID FROM BookRequestStatus brs INNER JOIN BookRequest br ON br.RequestID = brs.RequestID INNER JOIN Book b ON br.BookID = b.BookID WHERE b.BookID = @bookID";

                    SqlCommand getRequestIDCmd = new SqlCommand(getRequestIDQuery, con);
                    getRequestIDCmd.Parameters.AddWithValue("@bookID", bookID);

                    int requestID = -1;
                    using (SqlDataReader reader = getRequestIDCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            requestID = (int)reader["RequestID"];
                        }
                    }

                    if (requestID == -1)
                    {
                        MessageBox.Show("Request not found for this book!");

                        return;
                    }
                    bool chk = decreasebookUpdate(bookID);
                    issuedate = DateTime.Now;
                    if (chk)
                    {
                        string updateRequestQuery = "UPDATE BookRequestStatus " +
                                                 "SET Status = 'Issued' " +
                                                 "WHERE RequestID = @requestID";
                        SqlCommand updateRequestCmd = new SqlCommand(updateRequestQuery, con);
                        updateRequestCmd.Parameters.AddWithValue("@requestID", requestID);
                        updateRequestCmd.ExecuteNonQuery();

                        string insertQuery = "INSERT INTO BookIssue (BookID, StudentID, IssueDate,ReturnDate, UserID) " +
                                              "VALUES (@bookID, @studentID, @issueDate,@ReturnDate, @userID)";
                        SqlCommand cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@bookID", bookID);
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@issueDate", issuedate);
                        cmd.Parameters.AddWithValue("@ReturnDate", returndate.Value);
                        cmd.Parameters.AddWithValue("@userID", staffid.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book issued successfully!");
                        ShowDatainRequestedTable();
                        showissuedbooks();
                    }
                    
                    booktextbox.Text = "";
                    studenttextbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error issuing book: " + ex.Message);
                }
            }


        }
        bool validate()
        {
            issuedate = DateTime.Now;
           // int comparisonResult = DateTime.Compare(issuedate, returndate.Value);
            if (string.IsNullOrEmpty(booktextbox.Text) || string.IsNullOrEmpty(studenttextbox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            else if (returndate.Value < issuedate)
            {
                MessageBox.Show("Return date must be later than issue date.");
                return false;
            }
            return true;


        }
        private void showissuedbooks()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT s.RegistrationNo, Book.BookTitle, b.IssueDate, b.ReturnDate FROM BookRequestStatus AS brs JOIN BookRequest AS br ON brs.RequestID = br.RequestID JOIN Student AS s ON s.UserID = br.UserID JOIN BookIssue AS b ON b.StudentID = s.UserID JOIN Book ON b.BookID = Book.BookID WHERE brs.Status = 'Issued'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                issuebooktable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool decreasebookUpdate(int bookid)
        {
            bool flag = false;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string updateQuery = "Select AvailableCopies From Book Where BookID = @BookID";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@BookID", bookid);
                int tt = (int)cmd.ExecuteScalar();
                if (tt != 0)
                {
                    string updateQuery2 = "Update Book Set AvailableCopies = (AvailableCopies - 1) WHERE BookID = @BookID AND BookEdition = @Edition";
                    SqlCommand cmd2 = new SqlCommand(updateQuery2, con);
                    cmd2.Parameters.AddWithValue("@BookID", bookid);
                    cmd2.Parameters.AddWithValue("@Edition", edition);
                    cmd2.ExecuteNonQuery();
                    flag = true;
                }
                else
                {
                    MessageBox.Show($"Not enough Book Available");
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating shelf capacity: " + ex.Message);
            }
            return flag;

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
        private void ShowDatainRequestedTable()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PendingRequestsView", con);
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

        private void loadbutton_Click(object sender, EventArgs e)
        {
            showissuedbooks();
            ShowDatainRequestedTable();
        }
    }
}




