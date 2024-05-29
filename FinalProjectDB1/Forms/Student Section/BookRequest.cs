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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class BookRequest : Form
    {
        int UserID;
        public BookRequest(int userID)
        {
            InitializeComponent();
            getbookFromDatabase();
            UserID = userID;
            string stname = getStudentName();
            stdText.Text = stname;
        }
        public bool RequestBook(int bookID, int userID, int edition)
        {

            if (!IsUserActive(userID))
            {
                MessageBox.Show("User is inactive. Cannot request book.");
                return false;
            }
            if (GetAvailableCopies(bookID) == 0)
            {
                MessageBox.Show("No available copies of the book.");
                return false;
            }
            if (IsBookAlreadyRequestedByUser(bookID, userID, edition))
            {
                MessageBox.Show("You have already requested this book.");
                return false;
            }
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand command = new SqlCommand("InsertBookRequest", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", bookID);
                command.Parameters.AddWithValue("@UserID", userID);
                int userId = Convert.ToInt32(command.ExecuteScalar());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool IsUserActive(int userID)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Status FROM Student WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@UserID", userID);
            int status = (int)command.ExecuteScalar();

            return (status == 1);

        }

        public int GetAvailableCopies(int bookID)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT AvailableCopies FROM Book WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@BookID", bookID);
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return (int)result;
            }
            else
            {
                throw new InvalidOperationException("No available copies found for the specified book.");
            }

        }
        public bool IsBookAlreadyRequestedByUser(int bookID, int userID, int edition)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT COUNT(*) FROM BookRequest as r JOIN Book as B ON B.BookID = r.BookID  WHERE r.BookID = @BookID AND r.UserID = @UserID AND b.BookEdition = @Edition";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@BookID", bookID);
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Edition", edition);
            int requestCount = Convert.ToInt32(command.ExecuteScalar());
            return requestCount > 0;
        }
        private int getBookId(string Title, int edition)
        {
            int bookid = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT BookID FROM Book WHERE BookTitle = @Title AND BookEdition = @Edition";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Edition", edition);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    bookid = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(bookid.ToString());
            return bookid;
        }
        private void getBookEdition(string Title)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string selectQuery = "SELECT BookEdition FROM Book WHERE BookTitle = @BookTitle";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@BookTitle", Title);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int edition = (int)reader["BookEdition"]; // Cast to int
                    edcombo.Items.Add(edition.ToString()); // Convert to string before adding
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Book: " + ex.Message);
            }
        }


        private string getStudentName()
        {
            string StdName = "";
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT RegistrationNo FROM Student WHERE UserID = @id";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@id", UserID);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    StdName = (string)(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(StdName);
            return StdName;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btitle.Text) || string.IsNullOrEmpty(edcombo.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            try
            {

                string title = btitle.Text;
                int edition = int.Parse(edcombo.Text);
                int bookId = getBookId(title, edition);
                MessageBox.Show("id test", bookId.ToString());
                bool chking = RequestBook(bookId, UserID, edition);
                string stname = getStudentName();
                stdText.Text = stname;
                if (chking)
                {
                    MessageBox.Show("Book Request added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getbookFromDatabase()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT BookTitle AS Name FROM Book WHERE Status <> 0";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string AuthorName = reader["Name"].ToString();
                    btitle.Items.Add(AuthorName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Book: " + ex.Message);
            }
        }

        private void btitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            edcombo.Items.Clear();
            string selectedBookTitle = btitle.SelectedItem.ToString();
            getBookEdition(selectedBookTitle);
        }
    }
}
