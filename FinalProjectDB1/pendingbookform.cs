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
    public partial class pendingbookform : Form
    {
        public pendingbookform()
        {
            InitializeComponent();
        }

        private void pendingbookform_Load(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo, b.BookTitle, b.BookEdition, brs.Status AS Status, brs.RequestID FROM BookRequest br INNER JOIN Student s ON br.UserID = s.UserID INNER JOIN Book b ON br.BookID = b.BookID INNER JOIN BookRequestStatus brs ON br.RequestID = brs.RequestID WHERE brs.Status = 'Pending';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PendingBooks");
            PendingBook report = new PendingBook();
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
