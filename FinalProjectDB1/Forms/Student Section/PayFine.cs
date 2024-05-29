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

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class PayFine : Form
    {
        int studentID;
        public PayFine(int id)
        {
            InitializeComponent();
            studentID = id;
            getamount();
        }

        private void PayFine_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void royalButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(pamount.Text) || string.IsNullOrEmpty(tamount.Text))
            {
                MessageBox.Show("Please Fill all Required Fields");
                return;
            }
            float totamount = float.Parse(tamount.Text);
            float payamount = float.Parse(pamount.Text);
            if (payamount < 0 || payamount > totamount)
            {
                MessageBox.Show("Please enter valid amount");
                return;
            }
            if (payamount != totamount)
            {
                MessageBox.Show("Enter the full amount to be pay");
                return;
            }
            SqlTransaction transaction = null;
            try
            {
                var con = Configuration.getInstance().getConnection();
                transaction = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("INSERT INTO FinePayment VALUES (@Amount,@Date,@StudentID)", con,transaction);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Amount", payamount);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Update Student SET Status = 1 WHERE UserID = @StudentID", con,transaction);
                cmd2.Parameters.AddWithValue("@StudentID", studentID);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("Update FineDue SET Status = 'Payed' WHERE StudentID = @StudentID", con, transaction);
                cmd3.Parameters.AddWithValue("@StudentID", studentID);
                cmd3.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Fine payed Successfully, Now return the book to the Staff Otherwise you will be fined again");
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void getamount()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT TotalAmount FROM FineDue WHERE StudentID = @StudentID", con);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal amount;
                    if (decimal.TryParse(result.ToString(), out amount))
                    {
                        tamount.Text = amount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Failed to parse TotalAmount as decimal.");
                    }
                }
                else
                {
                    MessageBox.Show("TotalAmount is null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
