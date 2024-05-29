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
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class Return_Book : Form
    {
        int edition;
        int studentID;
        public Return_Book(int id)
        {
            InitializeComponent();
            studentID = id;
            ShowData();
        }
        public void ShowData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                MessageBox.Show(studentID.ToString());
                SqlCommand cmd = new SqlCommand("select b.BookTitle,b.BookEdition,bi.IssueDate,brs.Status from BookRequestStatus  as brs JOIN BookRequest as br ON br.RequestID = brs.RequestID JOIN Book as b ON br.BookID  = b.BookID JOIN BookIssue as bi ON bi.BookID = br.BookID Where brs.Status = 'Issued' AND br.UserID = @StudentID", con);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
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

        private void Ok_Click(object sender, EventArgs e)
        {
            string book = bookname.Text;
            string bStatus = status.Text;
            int bookId = getBookId(book, edition);
            int requestid = getRequestID(bookId);

            if (string.IsNullOrEmpty(book) || string.IsNullOrEmpty(bStatus))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE BookRequestStatus SET Status = 'Returned' WHERE RequestID = @RequestID", con);
                    cmd.Parameters.AddWithValue("@RequestID", requestid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Returned Successfully");
                    SqlCommand cmd2 = new SqlCommand("UPDATE Book SET AvailableCopies = (AvailableCopies+1) WHERE BookID = @BookID", con);
                    cmd2.Parameters.AddWithValue("@BookID", bookId);
                    cmd2.ExecuteNonQuery();
                    ShowData();
                }   
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    bookname.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    status.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    edition = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value?.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private int getRequestID(int bookid)
        {
            int requestID = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();

                string getRequestIDQuery = "SELECT brs.RequestID FROM BookRequestStatus brs INNER JOIN BookRequest br ON br.RequestID = brs.RequestID INNER JOIN Book b ON br.BookID = b.BookID WHERE b.BookID = @bookID";

                SqlCommand getRequestIDCmd = new SqlCommand(getRequestIDQuery, con);
                getRequestIDCmd.Parameters.AddWithValue("@bookID", bookid);


                using (SqlDataReader reader = getRequestIDCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        requestID = (int)reader["RequestID"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return requestID;
        }
    }
}
