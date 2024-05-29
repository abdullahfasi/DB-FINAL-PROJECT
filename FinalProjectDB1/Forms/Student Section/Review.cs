using DBMidProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class Review : Form
    {
        int Studentid;
        public Review(int id)
        {
            InitializeComponent();
            Studentid = id;
            dataload();
            loadcomboboxvalues();
        }



        public void dataload()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from BookReviewsView", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void loadcomboboxvalues()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Book.BookTitle From Book  Join BookRequest on BookRequest.BookID = Book.BookID Join BookRequestStatus on BookRequestStatus.RequestID =BookRequest.RequestID where  BookRequest.UserID = @UserID AND BookRequest.BookID NOT IN (SELECT BookID FROM Reviews) AND (BookRequestStatus.Status='Issued' Or BookRequestStatus.Status='Returned')", con);
            cmd.Parameters.AddWithValue("@UserID", Studentid);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BookComboBox.Items.Add(reader.GetString(0));
                }
            }

            reader.Close();
            cmd.ExecuteNonQuery();
        }


        private void Ok_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                try
                {

                    MessageBox.Show(Studentid.ToString());
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into Reviews values ((Select Book.BookID From Book Join BookRequest on  BookRequest.BookID = Book.BookID where Book.BookTitle=@BookName),@BookReview, @ReviewDate,@UserID)", con);

                    cmd.Parameters.AddWithValue("@BookName", BookComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BookReview", ReviewTextBox.Text);
                    cmd.Parameters.AddWithValue("@ReviewDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@UserID", Studentid);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Reviewed Book");
                    loadcomboboxvalues();
                    dataload();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                if (BookComboBox.SelectedItem == null)
                    MessageBox.Show("Please Select the Book Name.", "Message");
                else if (ReviewTextBox.Text == null)
                    MessageBox.Show("Please add the Review.", "Message");

            }
        }

        private bool validation()
        {
            if (BookComboBox.SelectedItem == null || ReviewTextBox.Text == null)
                return false;
            return true;
        }

        private void Clear()
        {
            BookComboBox.Items.Clear();
            ReviewTextBox.Text = null;
        }
    }


}
