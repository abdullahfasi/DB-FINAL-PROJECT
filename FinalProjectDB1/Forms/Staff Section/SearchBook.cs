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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
            LoadBookData();
        }

        private void FineHandling_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxEdit2.Text) || string.IsNullOrEmpty(comboBoxEdit2.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
                else
                {


                    string selectedCategory = comboBoxEdit1.SelectedItem.ToString();
                    string selectedValue = comboBoxEdit2.SelectedItem.ToString();

                    string query = "";
                    switch (selectedCategory)
                    {
                        case "Title":
                            query = "SELECT b.BookTitle, b.ISBNCode, c.CategoryName, p.PublisherName, b.PublicationYear, b.BookEdition, b.TotalCopies, b.AvailableCopies, LTRIM(RTRIM(a.FirstName)) + ' ' + LTRIM(RTRIM(a.LastName)) AS AuthorName, l.ShelfNo FROM Book b INNER JOIN Category c ON b.CategoryID = c.CategoryID INNER JOIN Publisher p ON b.PublisherID = p.PublisherID INNER JOIN Author a ON b.AuthorID = a.AuthorID INNER JOIN Location l ON b.LocationID = l.LocationID WHERE b.Status = 1 AND b.BookTitle = @value";
                            break;
                        case "Publisher":
                            query = "SELECT b.BookTitle, b.ISBNCode, c.CategoryName, p.PublisherName, b.PublicationYear, b.BookEdition, b.TotalCopies, b.AvailableCopies, LTRIM(RTRIM(a.FirstName)) + ' ' + LTRIM(RTRIM(a.LastName)) AS AuthorName, l.ShelfNo FROM Book b INNER JOIN Category c ON b.CategoryID = c.CategoryID INNER JOIN Publisher p ON b.PublisherID = p.PublisherID INNER JOIN Author a ON b.AuthorID = a.AuthorID INNER JOIN Location l ON b.LocationID = l.LocationID WHERE b.Status = 1 AND  p.PublisherName = @value";
                            break;
                        case "Category":
                            query = "SELECT b.BookTitle, b.ISBNCode, c.CategoryName, p.PublisherName, b.PublicationYear, b.BookEdition, b.TotalCopies, b.AvailableCopies, LTRIM(RTRIM(a.FirstName)) + ' ' + LTRIM(RTRIM(a.LastName)) AS AuthorName, l.ShelfNo FROM Book b INNER JOIN Category c ON b.CategoryID = c.CategoryID INNER JOIN Publisher p ON b.PublisherID = p.PublisherID INNER JOIN Author a ON b.AuthorID = a.AuthorID INNER JOIN Location l ON b.LocationID = l.LocationID WHERE b.Status = 1 AND c.CategoryName = @value";
                            break;
                            // case "Author":
                            //     query = "SELECT b.BookTitle, b.ISBNCode, c.CategoryName, p.PublisherName, b.PublicationYear, b.BookEdition, b.TotalCopies, b.AvailableCopies, LTRIM(RTRIM(a.FirstName)) + ' ' + LTRIM(RTRIM(a.LastName)) AS AuthorName, l.ShelfNo FROM Book b INNER JOIN Category c ON b.CategoryID = c.CategoryID INNER JOIN Publisher p ON b.PublisherID = p.PublisherID INNER JOIN Author a ON b.AuthorID = a.AuthorID INNER JOIN Location l ON b.LocationID = l.LocationID WHERE b.Status = 1 AND a."
                    }

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@value", selectedValue);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }
        private void LoadBookData()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select * from BookDetailsView", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book data: " + ex.Message);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadBookData();
                string selectedCategory = comboBoxEdit1.SelectedItem.ToString();
                MessageBox.Show(selectedCategory);

                var con = Configuration.getInstance().getConnection();
                string query = "";

                switch (selectedCategory)
                {
                    case "Title":
                        query = "SELECT DISTINCT BookTitle FROM Book";
                        break;
                    case "Publisher":
                        query = "SELECT DISTINCT p.PublisherName FROM Book JOIN Publisher as p ON p.PublisherID = Book.PublisherID";
                        break;
                    case "Category":
                        query = "SELECT DISTINCT c.CategoryName FROM Category as c JOIN Book ON c.CategoryID = Book.CategoryID";
                        break;
                }

                // MessageBox.Show(query);

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                comboBoxEdit2.Items.Clear();
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    comboBoxEdit2.Items.Add(value);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading search values: " + ex.Message);
            }

        }
    }
}

