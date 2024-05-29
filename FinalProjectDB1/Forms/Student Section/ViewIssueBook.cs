using DBMidProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class ViewIssueBook : Form
    {
        int Userid;
        public ViewIssueBook(int userid)
        {
            InitializeComponent();
            this.Userid = userid;
            ShowRequest();
        }
        private void ShowRequest()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select Student.RegistrationNo,LTRIM(RTRIM(FirstName)) + ' ' + LTRIM(RTRIM(LastName)) As Name,BookTitle,BookEdition,BookRequest.RequestDate,BookRequestStatus.Status From  Book JOIN BookRequest  ON Book.BookID  = BookRequest.BookID JOIN Student ON BookRequest.UserID = Student.UserID JOIN  [User] ON [User].UserID = Student.UserID JOIN BookRequestStatus ON BookRequest.RequestID = BookRequestStatus.RequestID Where BookRequest.UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", Userid);
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
            ShowRequest();
        }
    }
}
