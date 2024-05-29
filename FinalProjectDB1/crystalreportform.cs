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
    public partial class crystalreportform : Form
    {
        public crystalreportform()
        {
            InitializeComponent();
        }

        private void crystalreportform_Load(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT b.BookTitle, r.BookReview, r.ReviewDate, CONCAT(u.FirstName, ' ', u.LastName) AS FullName, s.RegistrationNo,u.Contact FROM Reviews r INNER JOIN Book b ON r.BookID = b.BookID INNER JOIN [User] u ON r.UserID = u.UserID INNER JOIN Student s ON r.UserID = s.UserID;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Reviews");
            ReviewsRPT report = new ReviewsRPT();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
       
    }
}
