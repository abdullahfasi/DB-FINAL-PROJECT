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
    public partial class AccountSetting : Form
    {
        int StaffID;
        public AccountSetting(int id)
        {
            InitializeComponent();
            StaffID = id;
            string staffName = getStaffName();
            string password = getStaffPassword();
            aname.Text = staffName;
            aoldpass.Text = password;
        }

        private void AccountSetting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {

            string old = aoldpass.Text;
            string Newp = anewpass.Text;
            string confirm = aconfirm.Text;
            if (string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(Newp))
            {
                MessageBox.Show("Please Fill all Required Fields");
            }

            else if (Newp == old)
            {
                MessageBox.Show("Do not Use Old Password Again, Enter a new Password");
            }
            else if (Newp != confirm)
            {
                MessageBox.Show("New password and confirm password must be equal");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Authentication SET Password = @Password WHERE UserID = @StaffID", con);
                cmd.Parameters.AddWithValue("@StaffID", StaffID);
                cmd.Parameters.AddWithValue("@Password", Newp);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully");
                anewpass.Clear();
                aconfirm.Clear();
            }
        }

        public string getStaffName()
        {
            string staffName = "";
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT LTRIM(RTRIM(FirstName)) + ' ' + LTRIM(RTRIM(LastName)) AS Name FROM [User] WHERE UserID = @StaffID", con);
                cmd.Parameters.AddWithValue("@StaffID", StaffID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        staffName = reader["Name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return staffName;
        }
        public string getStaffPassword()
        {
            string Password = "";
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Authentication WHERE UserID = @StaffID", con);
                cmd.Parameters.AddWithValue("@StaffID", StaffID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Password = reader["Password"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return Password;
        }

    }
}
