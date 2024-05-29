﻿using DBMidProject;
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
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeletePublisher : Form
    {
        string name;
        string type;
        string adress;
        string language;
        string eemail;
        public DeletePublisher()
        {
            InitializeComponent();
            ShowPublishers();
        }

        private void DeletePublisher_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }


        // Helper method to shuffle a list

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
            string pubname1 = pname.Text;
            string pubtype = ptype.Text;
            string publan = planguage.Text;
            string pubAdress = pAdress.Text;
            string pubemail = pemail.Text;

            string emailPattern = @"^\S+@gmail\.com";
            if (string.IsNullOrEmpty(pname.Text) || string.IsNullOrEmpty(ptype.Text) || string.IsNullOrEmpty(pAdress.Text) || string.IsNullOrEmpty(planguage.Text) || string.IsNullOrEmpty(pemail.Text))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(pemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }

            else
            {
                

                    int id = findID();
                    MessageBox.Show(id.ToString());
                    BL.Admin admin = new BL.Admin();
                    admin.DeletePublisher(pubname1, pubtype, publan, id, pubAdress, pubemail, 0);
                    ShowPublishers();
                    clear();
               
            }
        }
        private int findID()
        {
            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT PublisherID FROM Publisher WHERE  PublisherName = @PublisherName AND PublicationLanguage = @PublisherLanguage AND PublisherAddress = @PublisherAddress AND Email = @Email", con);
                cmd.Parameters.AddWithValue("@PublisherName", name);
                cmd.Parameters.AddWithValue("@PublisherType", type);
                cmd.Parameters.AddWithValue("@PublisherLanguage", language);
                cmd.Parameters.AddWithValue("@PublisherAddress", adress);
                cmd.Parameters.AddWithValue("@Email", eemail);
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    eemail = pemail.Text;
                    name = pname.Text;
                    type = ptype.Text;
                    language = planguage.Text;
                    adress = pAdress.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private void ShowPublishers()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT PublisherName,PublicationType,PublicationLanguage,PublisherAddress,Email FROM Publisher WHERE Status = 1", con); SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
