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
    public partial class BrowseBorrowBook : Form
    {
        public BrowseBorrowBook()
        {
            InitializeComponent();
            loaddataintable();
        }

        private void BrowseBorrowBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void loaddataintable()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT s.RegistrationNo, Book.BookTitle, b.IssueDate, b.ReturnDate, Author.FirstName + ' ' + Author.LastName AS AuthorName,Publisher.PublisherName FROM BookRequestStatus AS brs JOIN BookRequest AS br ON brs.RequestID = br.RequestID JOIN Student AS s ON s.UserID = br.UserID JOIN BookIssue AS b ON b.StudentID = s.UserID JOIN Book ON b.BookID = Book.BookID JOIN Author ON Book.AuthorID = Author.AuthorID JOIN Publisher ON Book.PublisherID = Publisher.PublisherID  WHERE brs.Status = 'Issued'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datatable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
