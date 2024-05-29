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
using System.Web.Mail;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddPublisher : Form
    {
        private int userid;
        public AddPublisher(int userid)
        {
            InitializeComponent();
            this.userid = userid;

            ShowPublishers();
        }

        private void foxBigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void clear()
        {
            pname.Text = "";
            ptype.Text = "";
            planguage.Text = "";
            pAdress.Text = "";
            pemail.Text = "";
        }
        private void royalButton1_Click(object sender, EventArgs e)
        {
            string publishername = pname.Text;
            string publishertype = ptype.Text;
            string publisherlanguage = planguage.Text;
            string publisherAdress = pAdress.Text;
            string pubemail = pemail.Text;
            string emailPattern = @"^\S+@gmail\.com";

            if (string.IsNullOrEmpty(pname.Text) || string.IsNullOrEmpty(ptype.Text) || string.IsNullOrEmpty(pAdress.Text) || string.IsNullOrEmpty(planguage.Text) || string.IsNullOrEmpty(pemail.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(pemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    BL.Admin admin = new BL.Admin();
                    admin.AddPublisher(publishername, publishertype, publisherlanguage, userid, publisherAdress, pubemail, 1);
                    ShowPublishers();
                    clear();
                }
                else
                {
                    MessageBox.Show("Already Exist");
                    clear();
                }
            }
        }

        private void ShowPublishers()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT PublisherName,PublicationType,PublicationLanguage,PublisherAddress,Email FROM Publisher WHERE Status = 1", con);
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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Publisher Where Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", pemail.Text);

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
                    pname.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    ptype.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    planguage.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    pAdress.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    pemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
