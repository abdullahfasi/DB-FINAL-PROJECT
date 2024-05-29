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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProjectDB1
{
    public partial class Overduefineform : Form
    {
        public Overduefineform()
        {
            InitializeComponent();
        }

        private void Overduefineform_Load(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo, CONCAT(u.FirstName,u.LastName) AS FullName, s.Department, SUM(f.TotalAmount) AS TotalAmount FROM Student s INNER JOIN FineDue f ON s.UserID = f.StudentID INNER JOIN BookIssue bi ON f.StudentID = bi.StudentID JOIN [User] u ON u.UserID = s.UserID WHERE f.Status = 'Unpayed' AND GETDATE() > bi.ReturnDate GROUP BY s.RegistrationNo, s.Department,CONCAT(u.FirstName,u.LastName) HAVING SUM(f.TotalAmount) > 0;\r\n", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Overdue Fine");
            OverdueFineCRPT report = new OverdueFineCRPT();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();

        }


    }
}
