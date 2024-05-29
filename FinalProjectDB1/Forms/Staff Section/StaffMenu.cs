using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProjectDB1.Forms.Staff_Section
{
    public partial class StaffMenu : Form
    {
       Forms.Staff_Section.BookIssuance BookI;
        Forms.Staff_Section.AccountSetting ASetting;
        Forms.Staff_Section.ApplyFine applyfine;
        Forms.Staff_Section.BrowseBorrowBook BorBook;
        Forms.Staff_Section.SearchBook FHandling;
        int Userid;
        public StaffMenu(int id)
        {
            InitializeComponent();
            //Add Midcontainer right
            this.IsMdiContainer = true;
            Userid = id;



        }

        /* Use for Side Bar*/
        bool sidebarexpand = false;

        //These are used in form movemenet Events
        bool Dragging;
        Point DragCursorPoint;
        Point DragFormPoint;

        private void AccountSetting_Btn_Click(object sender, EventArgs e)
        {
            if (ASetting == null)
            {
                ASetting = new Forms.Staff_Section.AccountSetting(Userid);
                ASetting.FormClosed += AccountSetting_FormClosed;
                ASetting.MdiParent = this;
                ASetting.Dock = DockStyle.Fill;
                ASetting.Show();

            }
            else
            {
                ASetting.Activate();
            }

        }
        private void AccountSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            ASetting = null;
        }

        private void FileHandling_Btn_Click(object sender, EventArgs e)
        {
            if (FHandling == null)
            {
                FHandling = new Forms.Staff_Section.SearchBook();
                FHandling.FormClosed += FineHandling_FormClosed;
                FHandling.MdiParent = this;
                FHandling.Dock = DockStyle.Fill;
                FHandling.Show();

            }
            else
            {
                FHandling.Activate();
            }

        }
        private void FineHandling_FormClosed(object sender, FormClosedEventArgs e)
        {
            FHandling = null;
        }

        private void BorrowedBook_Btn_Click(object sender, EventArgs e)
        {
            if (BorBook == null)
            {
                BorBook = new Forms.Staff_Section.BrowseBorrowBook();
                BorBook.FormClosed += BrowseBorrowBook_FormClosed;
                BorBook.MdiParent = this;
                BorBook.Dock = DockStyle.Fill;
                BorBook.Show();

            }
            else
            {
                BorBook.Activate();


            }
        }
        private void BrowseBorrowBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            BorBook = null;
        }


        private void CheckBookRequest_Btn_Click(object sender, EventArgs e)
        {
            if (applyfine == null)
            {
                applyfine = new Forms.Staff_Section.ApplyFine();
                applyfine.FormClosed += CheckBookRequest_FormClosed;
                applyfine.MdiParent = this;
                applyfine.Dock = DockStyle.Fill;
                applyfine.Show();

            }
            else
            {
                applyfine.Activate();
            }

        }
        private void CheckBookRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            applyfine = null;
        }

        private void BookIssuance_Btn_Click(object sender, EventArgs e)
        {
            if (BookI == null)
            {
                BookI = new Forms.Staff_Section.BookIssuance(Userid);
                BookI.FormClosed += BookIssuance_FormClosed;
                BookI.MdiParent = this;
                BookI.Dock = DockStyle.Fill;
                BookI.Show();

            }
            else
            {
                BookI.Activate();
            }
        }
        private void BookIssuance_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookI = null;
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

        private void Sidemenu_Btn_Click(object sender, EventArgs e)
        {
            sidemenutimer.Start();
        }



        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point Dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(Dif));
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Signout_Btn_Click(object sender, EventArgs e)
        {
            Forms.LogInSignUp.SignIn signin = new Forms.LogInSignUp.SignIn();
            this.Hide();
            signin.Show();
        }
    }
}
