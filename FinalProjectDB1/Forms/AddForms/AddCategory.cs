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
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddCategory : Form
    {
        public int AdminID;
        public AddCategory(int adminID)
        {
            InitializeComponent();

            AdminID = adminID;
            ShowCategory();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }



        private void royalButton1_Click(object sender, EventArgs e)
        {
            string categoryName = cname.Text;
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please Fill the required fields");
            }
            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    BL.Admin admin = new BL.Admin();
                    admin.AddCategory(categoryName, AdminID);
                    ShowCategory();
                    cname.Text = "";
                }
                else
                {
                    MessageBox.Show("Already Exist");
                    cname.Text = "";
                }

            }
        }

        private void ShowCategory()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID,CategoryName FROM Category ", con);
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
        private bool alreadyExist()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Category Where CategoryName = @Name", con);
            cmd.Parameters.AddWithValue("@name", cname.Text);

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
                    cname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
