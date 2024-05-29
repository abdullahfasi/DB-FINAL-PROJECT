using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class StudentMenu : Form
    {
        BookRequest BookReq;
        ViewIssueBook IssBook;
        Forms.Staff_Section.SearchBook SearchBook;
        ViewBook ViewB;
        PayFine payF;
        Return_Book retbook;
        Review R;
        int Userid;
        public StudentMenu(int userid)
        {
            InitializeComponent();
            //Add Midcontainer right
            this.IsMdiContainer = true;
            this.Userid = userid;
        }
        /* Use for Side Bar*/
        bool sidebarexpand = false;

        private void Sidemenu_Btn_Click(object sender, EventArgs e)
        {
            sidemenutimer.Start();
        }

        private void sidemenutimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 46)
                {
                    sidebarexpand = false;
                    sidemenutimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 237)
                {
                    sidebarexpand = true;
                    sidemenutimer.Stop();
                }
            }
        }

        private void BookRequest_Btn_Click(object sender, EventArgs e)
        {
            if (BookReq == null)
            {
                BookReq = new BookRequest(Userid);
                BookReq.FormClosed += BookReq_FormClosed;
                BookReq.MdiParent = this;
                BookReq.Dock = DockStyle.Fill;
                BookReq.Show();

            }
            else
            {
                BookReq.Activate();
            }
        }

        private void BookReq_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookReq.Activate();
        }

        private void ViewIssueBook_Btn_Click(object sender, EventArgs e)
        {
            if (IssBook == null)
            {
                IssBook = new ViewIssueBook(Userid);
                IssBook.FormClosed += IssBook_FormClosed;
                IssBook.MdiParent = this;
                IssBook.Dock = DockStyle.Fill;
                IssBook.Show();

            }
            else
            {
                IssBook.Activate();
            }
        }

        private void IssBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            IssBook.Activate();
        }

        private void SearchBook_Btn_Click(object sender, EventArgs e)
        {
            if (SearchBook == null)
            {
                SearchBook = new Forms.Staff_Section.SearchBook();
                SearchBook.FormClosed += SearchBook_FormClosed;
                SearchBook.MdiParent = this;
                SearchBook.Dock = DockStyle.Fill;
                SearchBook.Show();

            }
            else
            {
                SearchBook.Activate();
            }

        }
        private void SearchBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchBook.Activate();
        }

        private void Review_Btn_Click(object sender, EventArgs e)
        {
            if (R == null)
            {
                R = new Review(Userid);
                R .FormClosed += Review_FormClosed;
                R.MdiParent = this;
                R.Dock = DockStyle.Fill;
                R.Show();

            }
            else
            {
                R.Activate();
            }

        }

        private void Review_FormClosed(object sender, FormClosedEventArgs e)
        {
            R.Activate();
        }

        private void PayFine_Btn_Click(object sender, EventArgs e)
        {
            if (retbook == null)
            {
                retbook = new Return_Book(Userid);
                retbook.FormClosed += Return_Book_FormClosed;
                retbook.MdiParent = this;
                retbook.Dock = DockStyle.Fill;
                retbook.Show();

            }
            else
            {
                retbook.Activate();
            }
        }

        private void Return_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            retbook.Activate();
        }

        private void ViewPayedFine_Btn_Click(object sender, EventArgs e)
        {
            if (payF == null)
            {
                payF = new PayFine(Userid);
                payF.FormClosed += payF_FormClosed;
                payF.MdiParent = this;
                payF.Dock = DockStyle.Fill;
                payF.Show();
            }
            else
            {
                payF.Activate();
            }
        }

        private void payF_FormClosed(object sender, FormClosedEventArgs e)
        {
            payF.Activate();
        }

        private void Signout_Btn_Click(object sender, EventArgs e)
        {
            Forms.LogInSignUp.SignIn signin = new Forms.LogInSignUp.SignIn();
            this.Hide();
            signin.Show();
        }
    }
    

    
}


