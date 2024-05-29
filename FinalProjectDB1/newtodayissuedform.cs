using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class newtodayissuedform : Form
    {
        public newtodayissuedform()
        {
            InitializeComponent();
        }

        private void newtodayissuedform_Load(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT b.BookTitle , s.RegistrationNo, CONCAT(u.FirstName, ' ', u.LastName) AS AuthorName, u.CNIC,CONVERT(CHAR(5), bi.IssueDate, 108) AS IssueTime FROM BookIssue bi INNER JOIN Student s ON bi.StudentID = s.UserID INNER JOIN [User] u ON s.UserID = u.UserID INNER JOIN Book b ON bi.BookID = b.BookID WHERE CONVERT(DATE, bi.IssueDate) = CONVERT(DATE, GETDATE())", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "BookIssueToday");
            BookIssueTodatRPT report = new BookIssueTodatRPT();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();

        }
       
    }
}
