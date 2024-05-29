using DBMidProject;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Book
    {
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public int CategoryID { get; set; }
        public int PublisherID { get; set; }
        public int PublicationYear { get; set; }
        public int Edition { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public int LocationID { get; set; }

        public int AdminID { get; set; }

        public int AuthorID { get; set; }

        public int Status { get; set; }
        public Book(string title, string isbn, int categoryID, int publisherID, int publicationYear, int edition, int totalCopies, int availableCopies, int locationID,int adminid, int authorID, int status)
        {

            BookTitle = title;
            ISBN = isbn;
            CategoryID = categoryID;
            PublisherID = publisherID;
            PublicationYear = publicationYear;
            Edition = edition;
            TotalCopies = totalCopies;
            AvailableCopies = availableCopies;
            LocationID = locationID;
            AdminID = adminid;
            AuthorID = authorID;
            this.Status = status;
        }

        public void addBookToDatabase()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("AddBook", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", BookTitle);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                cmd.Parameters.AddWithValue("@PublisherID", PublisherID);
                cmd.Parameters.AddWithValue("@PublicationYear", PublicationYear);
                cmd.Parameters.AddWithValue("@Edition", Edition);
                cmd.Parameters.AddWithValue("@TotalCopies", TotalCopies);
                cmd.Parameters.AddWithValue("@AvailableCopies", AvailableCopies);
                cmd.Parameters.AddWithValue("@AdminID", AdminID);
                cmd.Parameters.AddWithValue("@LocationID", LocationID);
                cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
                cmd.Parameters.AddWithValue("@Status", Status);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void UpdateBookinDatabase()
        {
            try
            {
                MessageBox.Show(AdminID.ToString());
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UpdateBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", BookTitle);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                cmd.Parameters.AddWithValue("@PublisherID", PublisherID);
                cmd.Parameters.AddWithValue("@PublicationYear", PublicationYear);
                cmd.Parameters.AddWithValue("@Edition", Edition);
                cmd.Parameters.AddWithValue("@TotalCopies", TotalCopies);
                cmd.Parameters.AddWithValue("@AvailableCopies", AvailableCopies);
                cmd.Parameters.AddWithValue("@BookID", AdminID);
                cmd.Parameters.AddWithValue("@LocationID", LocationID);
                cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeleteBookFromBase()
        {
            try
            {
                MessageBox.Show(AdminID.ToString());
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DeleteBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                cmd.Parameters.AddWithValue("@PublisherID", PublisherID);
                cmd.Parameters.AddWithValue("@LocationID", LocationID);
                cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@BookID", AdminID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

    
}
