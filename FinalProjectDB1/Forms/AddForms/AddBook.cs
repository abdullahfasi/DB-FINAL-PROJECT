using DBMidProject;
using FinalProjectDB1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddBook : Form
    {
        int AdminID;
        string ISBN;
        public AddBook(int adminid)
        {
            InitializeComponent();
            AdminID = adminid;
            getCategoryFromDatabase();
            getPublisherFromDatabase();
            getLocationsFromDatabase();
            getAuthorsFromDatabase();
            ShowBook();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void ShowBook()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select * from BookDetailsView", con);
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
        private void clear()
        {
            bTcopies.Text = "";
            bTitle.Text = "";
            bEdition.Text = "";
            bAbooks.Text = "";
            bIsbn.Text = "";
        }
        private void royalButton1_Click(object sender, EventArgs e)
        {
            bool chk = validate();
            if (chk)
            {
                string title = bTitle.Text;
                string ISBN = bIsbn.Text;
                int categoryid = getCategoryID(bCategory.Text);
                int publisherid = getPublisherID(bPublisher.Text);
                DateTime dateTime = bPublicationDate.Value;
                int year = dateTime.Year;
                int Edition = int.Parse(bEdition.Text);
                int totalcopies = int.Parse(bTcopies.Text);
                int availablecopies = int.Parse(bAbooks.Text);
                int loc = int.Parse(bLocation.Text);
                int location = getLocationID(loc);
                int authorid = getAuthorID(bAuthor.Text);
                bool exist = alreadyExist();
                if (!exist)
                {
                    bool chkAwail = UpdateShelfCapacity(location, availablecopies);
                    if (chkAwail)
                    {

                        BL.Admin admin = new BL.Admin();
                        admin.AddBook(title, ISBN, categoryid, publisherid, year, Edition, totalcopies, availablecopies, location, AdminID, authorid, 1);
                        ShowBook();
                        clear();
                        getLocationsFromDatabase();

                    }
                }
                else
                {
                    MessageBox.Show("Already Exist");
                }
            }


        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(bTitle.Text) || string.IsNullOrEmpty(bIsbn.Text) || string.IsNullOrEmpty(bCategory.Text) ||
                string.IsNullOrEmpty(bPublisher.Text) || string.IsNullOrEmpty(bEdition.Text) ||
                string.IsNullOrEmpty(bTcopies.Text) || string.IsNullOrEmpty(bAbooks.Text) ||
                string.IsNullOrEmpty(bLocation.Text))
            {
                MessageBox.Show("Please fill all the required fields.");
                return false;
            }
            else if (!IsNumeric(bEdition.Text) || !IsNumeric(bTcopies.Text) || !IsNumeric(bAbooks.Text))
            {
                MessageBox.Show("Edition, Total Copies, and Available Copies should be numeric.");
                return false;
            }
            else if (bIsbn.Text.Length != 10)
            {
                MessageBox.Show("ISBN should be a 10-digit numeric value.");
                return false;
            }

            else if (bTcopies.Text != bAbooks.Text)
            {
                MessageBox.Show("During adding total copies must be equal to available copies.");
                return false;
            }
            return true;
        }
        bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private bool UpdateShelfCapacity(int locationId, int availableCopies)
        {
            bool flag = false;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string updateQuery = "Select capacity From Location Where LocationID = @locationId";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@locationId", locationId);
                int tt = (int)cmd.ExecuteScalar();
                if ((tt - availableCopies) >= 0)
                {
                    string updateQuery2 = "Update Location Set Capacity = (Capacity - @AvailableCopies) WHERE LocationID = @locationId ";
                    SqlCommand cmd2 = new SqlCommand(updateQuery2, con);
                    cmd2.Parameters.AddWithValue("@availableCopies", availableCopies);
                    cmd2.Parameters.AddWithValue("@locationId", locationId);
                    cmd2.ExecuteNonQuery();
                    flag = true;
                }
                else
                {
                    MessageBox.Show($"Not enough space available in that location. Only {tt} space(s) available.");
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating shelf capacity: " + ex.Message);
            }
            return flag;
        }

        private void getCategoryFromDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT CategoryName FROM Category";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader["CategoryName"].ToString();
                    bCategory.Items.Add(categoryName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category names: " + ex.Message);
            }
        }

        private void getPublisherFromDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT PublisherName FROM Publisher WHERE Status <> 0";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PublisherName = reader["PublisherName"].ToString();
                    bPublisher.Items.Add(PublisherName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Publisher names: " + ex.Message);
            }
        }

        private void getLocationsFromDatabase()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT ShelfNo FROM Location";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ShelfNo = Convert.ToInt32(reader["ShelfNo"]);
                    bLocation.Items.Add(ShelfNo);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Locations: " + ex.Message);
            }
        }

        private void getAuthorsFromDatabase()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT LTRIM(RTRIM(FirstName)) + ' ' + LTRIM(RTRIM(LastName)) AS Name FROM Author WHERE Status <> 0";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string AuthorName = reader["Name"].ToString();
                    bAuthor.Items.Add(AuthorName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Author: " + ex.Message);
            }
        }


        private int getCategoryID(string categoryName)
        {
            int categoryId = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    categoryId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(categoryId.ToString());
            return categoryId;
        }

        private int getPublisherID(string publisherName)
        {
            int PublisherId = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT PublisherID FROM Publisher WHERE PublisherName = @publisherName";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@publisherName", publisherName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    PublisherId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(PublisherId.ToString());
            return PublisherId;
        }

        private int getLocationID(int shelfno)
        {
            int LocationID = -1;
            try
            {

                var con = Configuration.getInstance().getConnection();
                string insertQuery = "SELECT LocationID FROM Location WHERE ShelfNo = @ShelfNo";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@ShelfNo", shelfno);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    LocationID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(LocationID.ToString());
            return LocationID;
        }

        private int getAuthorID(string fullName)
        {
            int authorId = -1;
            try
            {
                var con = Configuration.getInstance().getConnection();

                string selectQuery = "SELECT AuthorID FROM Author WHERE LTRIM(RTRIM(FirstName)) + ' ' + LTRIM(RTRIM(LastName)) = @fullName";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    authorId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(authorId.ToString());
            return authorId;
        }
        private bool alreadyExist()
        {


            var con = Configuration.getInstance().getConnection();
            string selectQuery = "SELECT COUNT(*) FROM Book WHERE ISBNCode = @ISBN AND BookEdition = @Edition";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@ISBN", bIsbn.Text);
            cmd.Parameters.AddWithValue("@Edition", bEdition.Text);
            int id = (int)cmd.ExecuteScalar();
            MessageBox.Show(id.ToString());
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    bTitle.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    bIsbn.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    bCategory.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    bPublisher.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    bPublisher.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    bEdition.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
                    bTcopies.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    bAbooks.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    bAuthor.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    bLocation.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

