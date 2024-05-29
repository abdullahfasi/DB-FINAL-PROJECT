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

namespace FinalProjectDB1.Forms.DashBoard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            showTotalStudent();
            showTotalBooks();
            showTotalIssuedBooks();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {

            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select * from StudentDetailsView", con);
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


        private void royalButton2_Click(object sender, EventArgs e)
        {
            ShowBook();
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

        private void ShowIssueBook()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select * from IssuedBooksView", con);
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

        private void showTotalStudent()
        {
            var con = Configuration.getInstance().getConnection();
            string countQuery = "SELECT COUNT(*) FROM Student";
            SqlCommand cmd = new SqlCommand(countQuery, con);
            int totalStudents = Convert.ToInt32(cmd.ExecuteScalar());
            std.Text = totalStudents.ToString();
        }
        private void showTotalBooks()
        {
            var con = Configuration.getInstance().getConnection();
            string countQuery = "SELECT COUNT(*) FROM Book WHERE Status <> 0";
            SqlCommand cmd = new SqlCommand(countQuery, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            totalBooks.Text = total.ToString();
        }
        private void showTotalIssuedBooks()
        {
            var con = Configuration.getInstance().getConnection();
            string countQuery = "SELECT COUNT(*) FROM BookRequestStatus WHERE Status = 'Issued'";
            SqlCommand cmd = new SqlCommand(countQuery, con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            totalissuedbooks.Text = total.ToString();
        }

        private void IssuedBooks_Click(object sender, EventArgs e)
        {
            ShowIssueBook();
        }

        private void skyLabel1_Click(object sender, EventArgs e)
        {
            ShowBook();
        }

        private void skyLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select s.RegistrationNo, u.FirstName, u.LastName,a.Email,a.Password, u.Contact,s.Department,s.Semester,u.CNIC, CASE WHEN Status = 1 THEN 'Active' WHEN Status = 2 THEN 'InActive' END AS Status,u.City, StudentShip_StartDate from student as s JOIN [user] as u on s.UserID = u.UserID JOIN Authentication AS a ON  u.UserID = a.UserID WHERE LEFT(u.FirstName,1) <> '-'", con);
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

        private void skyLabel3_Click(object sender, EventArgs e)
        {
            ShowIssueBook();
        }
    }
}
