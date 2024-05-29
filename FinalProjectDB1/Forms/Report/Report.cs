using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.Report
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            Overduefineform f = new Overduefineform();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newtodayissuedform f = new newtodayissuedform();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            overduebookreoprt f = new overduebookreoprt();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalreportform f = new crystalreportform();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pendingbookform f = new pendingbookform();
            f.Show();
        }
    }
}
