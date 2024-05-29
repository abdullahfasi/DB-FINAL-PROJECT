using CrystalDecisions.CrystalReports.Engine;
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

namespace FinalProjectDB1
{
    public partial class overduebookreoprt : Form
    {
        public overduebookreoprt()
        {
            InitializeComponent();
        }

        private void overduebookreoprt_Load(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT b.BookTitle, s.RegistrationNo, b.ISBNCode, bi.IssueDate, bi.ReturnDate FROM BookIssue bi INNER JOIN Book b ON bi.BookID = b.BookID INNER JOIN Student s ON bi.StudentID = s.UserID WHERE GETDATE() > bi.ReturnDate", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "BookOverDue");
            OverDueBook report = new OverDueBook();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
       
    }
}
