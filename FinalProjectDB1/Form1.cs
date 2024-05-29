﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace FinalProjectDB1
{
    public partial class Form1 : Form
    {
        Forms.DashBoard.Dashboard dashboard;
        Forms.AddForms.AddStudent Astudent;
        Forms.UpdateForms.UpdateStudent UStudent;
        Forms.DeleteForms.DeleteStudent DStudent;


        Forms.AddForms.AddAdmin AAdmin;
        Forms.UpdateForms.UpdateAdmin UAdmin;
        Forms.DeleteForms.DeleteAdmin DAdmin;


        Forms.AddForms.AddStaff AStaff;
        Forms.UpdateForms.UpdateStaff UStaff;
        Forms.DeleteForms.DeleteStaff DStaff;


        Forms.AddForms.AddCategory ACat;
        Forms.DeleteForms.DeleteCategory DCat;


        Forms.AddForms.AddPublisher APub;
        Forms.UpdateForms.UpdatePublisher UPub;
        Forms.DeleteForms.DeletePublisher DPub;

        Forms.AddForms.AddBook ABook;
        Forms.UpdateForms.UpdateBook UBook;
        Forms.DeleteForms.DeleteBook DBook;


        Forms.AddForms.AddAuthor AAuthor;
        Forms.UpdateForms.UpdateAuthor UAuthor;
        Forms.DeleteForms.DeleteAuthor DAuthor;

        Forms.AddForms.AddLocation alocation;
        Forms.DeleteForms.DeleteLocation dlocation;

        Forms.Report.Report rep;

        int AdminUserid;
        public Form1(int adminuserid)
        {
           
            InitializeComponent();
            MdiProp();
            AdminUserid = adminuserid;
        }

        /* Use for Student Menue*/ bool meueExpand = false;
        /* Use for Staff Menue*/ bool meueExpand1 = false;
        /* Use for Admin Menue*/ bool meueExpand2 = false;
        /* Use for Book Menue*/bool meueExpand3 = false;
        /* Use for Publisher Menue*/ bool meueExpand4 = false;
        /* Use for Category Menue*/bool meueExpand5 = false;
        /* Use for  Author Menue*/ bool meueExpand6 = false;
        /* Use for  location Menue*/ bool meueExpand7 = false;

        /* Use for Side Bar*/ bool sidebarexpand = false;

        //These are used in form movemenet Events
        bool Dragging;
        Point DragCursorPoint;
        Point DragFormPoint;

       

        //Student Menue Bar
        private void MenuTransistion_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand == false)
                {
                    studentmenu.Height += 10;
                    if (studentmenu.Height >= 215)
                    {
                        MenuTransistion.Stop();
                        meueExpand = true;
                    }

                }
                else
                {
                    studentmenu.Height -= 10;
                    if (studentmenu.Height <= 52)
                    {
                        MenuTransistion.Stop();
                        meueExpand = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand == false)
                {
                    studentmenu.Height += 10;
                    if (studentmenu.Height >= 215)
                    {
                        MenuTransistion.Stop();
                        meueExpand = true;
                    }

                }
                else
                {
                    studentmenu.Height -= 10;
                    if (studentmenu.Height <= 52)
                    {
                        MenuTransistion.Stop();
                        meueExpand = false;
                    }
                }

            }
        }

        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            MenuTransistion.Start();
        }
        // End of Student Menu Bar

        //Start of Staff Menu Bar
        private void stafftimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand1 == false)
                {
                    staffmenu.Height += 10;
                    if (staffmenu.Height >= 215)
                    {
                        stafftimer.Stop();
                        meueExpand1 = true;
                    }

                }
                else
                {
                    staffmenu.Height -= 10;
                    if (staffmenu.Height <= 52)
                    {
                        stafftimer.Stop();
                        meueExpand1 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand1 == false)
                {
                    staffmenu.Height += 10;
                    if (staffmenu.Height >= 215)
                    {
                        stafftimer.Stop();
                        meueExpand1 = true;
                    }

                }
                else
                {
                    staffmenu.Height -= 10;
                    if (staffmenu.Height <= 52)
                    {
                        stafftimer.Stop();
                        meueExpand1 = false;
                    }
                }
            }
        }

        private void ManageStaffBtn_Click(object sender, EventArgs e)
        {
            stafftimer.Start();
        }
        //End of staff Menu Bar

        //Start of admin Menu Bar

        private void admintimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand2 == false)
                {
                    Adminmenu.Height += 10;
                    if (Adminmenu.Height >= 215)
                    {
                        admintimer.Stop();
                        meueExpand2 = true;
                    }

                }
                else
                {
                    Adminmenu.Height -= 10;
                    if (Adminmenu.Height <= 52)
                    {
                        admintimer.Stop();
                        meueExpand2 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand2 == false)
                {
                    Adminmenu.Height += 10;
                    if (Adminmenu.Height >= 215)
                    {
                        admintimer.Stop();
                        meueExpand2 = true;
                    }

                }
                else
                {
                    Adminmenu.Height -= 10;
                    if (Adminmenu.Height <= 52)
                    {
                        admintimer.Stop();
                        meueExpand2 = false;
                    }
                }
            }

        }

        private void ManageAdminBtn_Click(object sender, EventArgs e)
        {
            admintimer.Start();
        }

        // End of admin bar

        //Start of Book menu
        private void Booktimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand3 == false)
                {
                    Bookmenu.Height += 10;
                    if (Bookmenu.Height >= 215)
                    {
                        Booktimer.Stop();
                        meueExpand3 = true;
                    }

                }
                else
                {
                    Bookmenu.Height -= 10;
                    if (Bookmenu.Height <= 52)
                    {
                        Booktimer.Stop();
                        meueExpand3 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand3 == false)
                {
                    Bookmenu.Height += 10;
                    if (Bookmenu.Height >= 215)
                    {
                        Booktimer.Stop();
                        meueExpand3 = true;
                    }

                }
                else
                {
                    Bookmenu.Height -= 10;
                    if (Bookmenu.Height <= 52)
                    {
                        Booktimer.Stop();
                        meueExpand3 = false;
                    }
                }
            }


        }

        private void Bookmenubtn_Click(object sender, EventArgs e)
        {
            Booktimer.Start();
        }
        // End of Book menu

        //Start of Publisher Menu

        private void Publishertimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand4 == false)
                {
                    Publishermenu.Height += 10;
                    if (Publishermenu.Height >= 215)
                    {
                        Publishertimer.Stop();
                        meueExpand4 = true;
                    }

                }
                else
                {
                    Publishermenu.Height -= 10;
                    if (Publishermenu.Height <= 52)
                    {
                        Publishertimer.Stop();
                        meueExpand4 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand4 == false)
                {
                    Publishermenu.Height += 10;
                    if (Publishermenu.Height >= 215)
                    {
                        Publishertimer.Stop();
                        meueExpand4 = true;
                    }

                }
                else
                {
                    Publishermenu.Height -= 10;
                    if (Publishermenu.Height <= 52)
                    {
                        Publishertimer.Stop();
                        meueExpand4 = false;
                    }
                }
            }
        }

        private void Publishermenubtn_Click(object sender, EventArgs e)
        {
            Publishertimer.Start();
        }


        // End of Publisher Menu
        // Start of Category Menu
        private void Categorytimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand5 == false)
                {
                    Categorymenu.Height += 10;
                    if (Categorymenu.Height >= 158)
                    {
                        Categorytimer.Stop();
                        meueExpand5 = true;
                    }

                }
                else
                {
                    Categorymenu.Height -= 10;
                    if (Categorymenu.Height <= 52)
                    {
                        Categorytimer.Stop();
                        meueExpand5 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand5 == false)
                {
                    Categorymenu.Height += 10;
                    if (Categorymenu.Height >= 158)
                    {
                        Categorytimer.Stop();
                        meueExpand5 = true;
                    }

                }
                else
                {
                    Categorymenu.Height -= 10;
                    if (Categorymenu.Height <= 52)
                    {
                        Categorytimer.Stop();
                        meueExpand5 = false;
                    }
                }
            }
        }


        private void Categorymenubtn_Click(object sender, EventArgs e)
        {
            Categorytimer.Start();
        }
        // End of Catgory Menu
        // Start of Author menu

        private void Authortimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand6 == false)
                {
                    Authormenu.Height += 10;
                    if (Authormenu.Height >= 215)
                    {
                        Authortimer.Stop();
                        meueExpand6 = true;
                    }

                }
                else
                {
                    Authormenu.Height -= 10;
                    if (Authormenu.Height <= 52)
                    {
                        Authortimer.Stop();
                        meueExpand6 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand6 == false)
                {
                    Authormenu.Height += 10;
                    if (Authormenu.Height >= 215)
                    {
                        Authortimer.Stop();
                        meueExpand6 = true;
                    }

                }
                else
                {
                    Authormenu.Height -= 10;
                    if (Authormenu.Height <= 52)
                    {
                        Authortimer.Stop();
                        meueExpand6 = false;
                    }
                }
            }



        }

        private void Authormenubtn_Click(object sender, EventArgs e)
        {
            Authortimer.Start();
        }
        // End of Author menu




        // Side bar control code start

        private void sidemenutimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 46)
                {
                    sidebarexpand = false;
                    Inventory.Visible = false;
                    sidemenutimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 237)
                {
                    sidebarexpand = true;
                    Inventory.Visible = true;
                    sidemenutimer.Stop();
                }
            }
        }

        private void Sidemenu_Click(object sender, EventArgs e)
        {
            
            sidemenutimer.Start();
        }
        // Side bar control code End

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState=FormWindowState.Normal;
                this.StartPosition=FormStartPosition.CenterParent;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        // This Events are used for Form movement 

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint=Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Dragging)
            {
                Point Dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(Dif));
            }
        }
        // End of this events


        private void Dashbutton_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Forms.DashBoard.Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;    
                dashboard.Show();

            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void AddStd_Btn_Click(object sender, EventArgs e)
        {

             if (Astudent == null)
             {
                 Astudent = new Forms.AddForms.AddStudent();
                 Astudent.FormClosed += AddStudent_FormClosed;
                 Astudent.MdiParent = this;
                 Astudent.Dock = DockStyle.Fill;
                 Astudent.Show();
             
             }
             else
             {
                 Astudent.Activate();
             }
           
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Astudent.Activate();
        }

        private void UpdateStd_Btn_Click(object sender, EventArgs e)
        {
            if (UStudent == null)
            {
                UStudent = new Forms.UpdateForms.UpdateStudent();
                UStudent.FormClosed += UpdateStudent_FormClosed;
                UStudent.MdiParent = this;
                UStudent.Dock = DockStyle.Fill;
                UStudent.Show();

            }
            else
            {
                UStudent.Activate();
            }

        }

        private void UpdateStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            UStudent.Activate();
        }

        private void DeleteStd_Btn_Click(object sender, EventArgs e)
        {
            if (DStudent == null)
            {
                DStudent = new Forms.DeleteForms.DeleteStudent();
                DStudent.FormClosed += DeleteStudent_FormClosed;
                DStudent.MdiParent = this;
                DStudent.Dock = DockStyle.Fill;
                DStudent.Show();

            }
            else
            {
                DStudent.Activate();
            }
        }

        private void DeleteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            DStudent.Activate();
        }

        private void AddAdmin_Btn_Click(object sender, EventArgs e)
        {
            if (AAdmin == null)
            {
                AAdmin = new Forms.AddForms.AddAdmin();
                AAdmin.FormClosed += AddAdmincs_FormClosed;
                AAdmin.MdiParent = this;
                AAdmin.Dock = DockStyle.Fill;
                AAdmin.Show();

            }
            else
            {
                AAdmin.Activate();
            }

        }

        private void AddAdmincs_FormClosed(object sender, FormClosedEventArgs e)
        {
            AAdmin.Activate();
        }

        private void UpdateAdmin_Btn_Click(object sender, EventArgs e)
        {
            if (UAdmin == null)
            {
                UAdmin = new Forms.UpdateForms.UpdateAdmin();
                UAdmin.FormClosed += UpdateAdmin_FormClosed;
                UAdmin.MdiParent = this;
                UAdmin.Dock = DockStyle.Fill;
                UAdmin.Show();

            }
            else
            {
                UAdmin.Activate();
            }

        }

        private void UpdateAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            UAdmin.Activate();
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            if (DAdmin == null)
            {
                DAdmin = new Forms.DeleteForms.DeleteAdmin();
                DAdmin.FormClosed += DeleteAdmin_FormClosed;
                DAdmin.MdiParent = this;
                DAdmin.Dock = DockStyle.Fill;
                DAdmin.Show();

            }
            else
            {
                DAdmin.Activate();
            }
        }

        private void DeleteAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAdmin.Activate(); 
        }

        private void AddStaff_Btn_Click(object sender, EventArgs e)
        {
            if (AStaff == null)
            {
                AStaff = new Forms.AddForms.AddStaff();
                AStaff.FormClosed += AddStaff_FormClosed;
                AStaff.MdiParent = this;
                AStaff.Dock = DockStyle.Fill;
                AStaff.Show();

            }
            else
            {
                AStaff.Activate();
            }

        }

        private void AddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            AStaff.Activate();
        }

        private void UpdateStaff_Btn_Click(object sender, EventArgs e)
        {
            if (UStaff == null)
            {
                UStaff = new Forms.UpdateForms.UpdateStaff();
                UStaff.FormClosed += UpdateStaff_FormClosed;
                UStaff.MdiParent = this;
                UStaff.Dock = DockStyle.Fill;
                UStaff.Show();

            }
            else
            {
                UStaff.Activate();
            }

        }

        private void UpdateStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            UStaff.Activate();
        }

        private void DeleteStaff_Btn_Click(object sender, EventArgs e)
        {
            if (DStaff == null)
            {
                DStaff = new Forms.DeleteForms.DeleteStaff();
                DStaff.FormClosed += DeleteStaff_FormClosed;
                DStaff.MdiParent = this;
                DStaff.Dock = DockStyle.Fill;
                DStaff.Show();

            }
            else
            {
                DStaff.Activate();
            }


        }

        private void DeleteStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            DStaff.Activate();
        }

        private void AddCategory_Btn_Click(object sender, EventArgs e)
        {
            if (ACat == null)
            {
                ACat = new Forms.AddForms.AddCategory(AdminUserid);
                ACat.FormClosed += AddCategory_FormClosed;
                ACat.MdiParent = this;
                ACat.Dock = DockStyle.Fill;
                ACat.Show();

            }
            else
            {
                ACat.Activate();
            }
        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ACat.Activate();
        }


       

        private void DeleteCategory_Btn_Click(object sender, EventArgs e)
        {
            if (DCat == null)
            {
                DCat = new Forms.DeleteForms.DeleteCategory();
                DCat.FormClosed += DeleteCategory_FormClosed;
                DCat.MdiParent = this;
                DCat.Dock = DockStyle.Fill;
                DCat.Show();

            }
            else
            {
                DCat.Activate();
            }
        }

        private void DeleteCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            DCat.Activate();
        }

        private void AddPublisher_Btn_Click(object sender, EventArgs e)
        {
            if (APub == null)
            {
                APub = new Forms.AddForms.AddPublisher(AdminUserid);
                APub.FormClosed += AddPublisher_FormClosed;
                APub.MdiParent = this;
                APub.Dock = DockStyle.Fill;
                APub.Show();

            }
            else
            {
                APub.Activate();
            }

        }

        private void AddPublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            APub.Activate();
        }

        private void UpdatePublisher_Btn_Click(object sender, EventArgs e)
        {
            if (UPub == null)
            {
                UPub = new Forms.UpdateForms.UpdatePublisher();
                UPub.FormClosed += UpdatePublisher_FormClosed;
                UPub.MdiParent = this;
                UPub.Dock = DockStyle.Fill;
                UPub.Show();

            }
            else
            {
                UPub.Activate();
            }

        }

        private void UpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            UPub.Activate();
        }

        private void DeletePublisher_Click(object sender, EventArgs e)
        {
            if (DPub == null)
            {
                DPub = new Forms.DeleteForms.DeletePublisher();
                DPub.FormClosed += DeletePublisher_FormClosed;
                DPub.MdiParent = this;
                DPub.Dock = DockStyle.Fill;
                DPub.Show();

            }
            else
            {
                DPub.Activate();
            }

        }

        private void DeletePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            DPub.Activate();
        }

        private void AddBook_Btn_Click(object sender, EventArgs e)
        {
            if (ABook == null)
            {
                ABook = new Forms.AddForms.AddBook(AdminUserid);
                ABook.FormClosed += AddBook_FormClosed;
                ABook.MdiParent = this;
                ABook.Dock = DockStyle.Fill;
                ABook.Show();

            }
            else
            {
                ABook.Activate();
            }

        }

        private void AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            ABook.Activate();
        }

        private void UpdateBook_Btn_Click(object sender, EventArgs e)
        {
            if (UBook == null)
            {
                UBook = new Forms.UpdateForms.UpdateBook();
                UBook.FormClosed += UpdateBook_FormClosed;
                UBook.MdiParent = this;
                UBook.Dock = DockStyle.Fill;
                UBook.Show();

            }
            else
            {
                UBook.Activate();
            }

        }

        private void UpdateBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            UBook.Activate();
        }

        private void DeleteBook_Btn_Click(object sender, EventArgs e)
        {
            if (DBook == null)
            {
                DBook = new Forms.DeleteForms.DeleteBook();
                DBook.FormClosed += DeleteBook_FormClosed;
                DBook.MdiParent = this;
                DBook.Dock = DockStyle.Fill;
                DBook.Show();

            }
            else
            {
                DBook.Activate();
            }
        }

        private void DeleteBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBook.Activate();
        }

        private void AddAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (AAuthor == null)
            {
                AAuthor = new Forms.AddForms.AddAuthor(AdminUserid);
                AAuthor.FormClosed += AddAuthor_FormClosed;
                AAuthor.MdiParent = this;
                AAuthor.Dock = DockStyle.Fill;
                AAuthor.Show();

            }
            else
            {
                AAuthor.Activate();
            }

        }

        private void AddAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            AAuthor.Activate();
        }

        private void UpdateAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (UAuthor == null)
            {
                UAuthor = new Forms.UpdateForms.UpdateAuthor();
                UAuthor.FormClosed += UpdateAuthor_FormClosed;
                UAuthor.MdiParent = this;
                UAuthor.Dock = DockStyle.Fill;
                UAuthor.Show();

            }
            else
            {
                UAuthor.Activate();
            }
        }

        private void UpdateAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            UAuthor.Activate();
        }

        private void DeleteAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (DAuthor == null)
            {
                DAuthor = new Forms.DeleteForms.DeleteAuthor();
                DAuthor.FormClosed += DeleteAuthor_FormClosed;
                DAuthor.MdiParent = this;
                DAuthor.Dock = DockStyle.Fill;
                DAuthor.Show();

            }
            else
            {
                DAuthor.Activate();
            }

        }

        private void DeleteAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAuthor.Activate();
        }


        private void MdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addlocation_Click(object sender, EventArgs e)
        {
            if (alocation == null)
            {
                alocation = new Forms.AddForms.AddLocation(AdminUserid);
                alocation.FormClosed += addlocation_FormClosed;
                alocation.MdiParent = this;
                alocation.Dock = DockStyle.Fill;
                alocation.Show();

            }
            else
            {
                alocation.Activate();
            }
        }

        private void addlocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            alocation.Activate();
        }

        private void LocationTimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnySubmenueOpen())
            {
                if (meueExpand7 == false)
                {
                    locationmenu.Height += 10;
                    if (locationmenu.Height >= 158)
                    {
                        LocationTimer.Stop();
                        meueExpand7 = true;
                    }

                }
                else
                {
                    locationmenu.Height -= 10;
                    if (locationmenu.Height <= 52)
                    {
                        LocationTimer.Stop();
                        meueExpand7 = false;
                    }
                }
            }
            else
            {
                CloseAllSubmenus();
                if (meueExpand7 == false)
                {
                    locationmenu.Height += 10;
                    if (locationmenu.Height >= 158)
                    {
                        LocationTimer.Stop();
                        meueExpand7 = true;
                    }

                }
                else
                {
                    locationmenu.Height -= 10;
                    if (locationmenu.Height <= 52)
                    {
                        LocationTimer.Stop();
                        meueExpand7 = false;
                    }
                }
            }
        }

        private void manage_Click(object sender, EventArgs e)
        {
            LocationTimer.Start();
        }

        private void deletelocation_Click(object sender, EventArgs e)
        {
            if (dlocation == null)
            {
                dlocation = new Forms.DeleteForms.DeleteLocation();
                dlocation.FormClosed += deletelocation_FormClosed;
                dlocation.MdiParent = this;
                dlocation.Dock = DockStyle.Fill;
                dlocation.Show();

            }
            else
            {
                dlocation.Activate();
            }
        }

        private void deletelocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlocation.Activate();
        }


        private bool CheckAnySubmenueOpen()
        {
            if (meueExpand == false || meueExpand1 == false || meueExpand2 == false || meueExpand3 == false || meueExpand4 == false || meueExpand5 == false || meueExpand6 == false || meueExpand7 == false)
                return false;
            return true;
        }
        private void CloseAllSubmenus()
        {

            if (meueExpand)
            {
                studentmenu.Height = 42;
                meueExpand = false;
                MenuTransistion.Stop();

            }
            if (meueExpand1)
            {

                staffmenu.Height = 42;
                meueExpand1 = false;
                stafftimer.Stop();
            }
            if (meueExpand2)
            {

                Adminmenu.Height = 42;
                meueExpand2 = false;
                admintimer.Stop();

            }
            if (meueExpand3)
            {

                Bookmenu.Height = 42;
                meueExpand3 = false;
                Booktimer.Stop();

            }
            if (meueExpand4)
            {

                Publishermenu.Height = 42;
                meueExpand4 = false;
                Publishertimer.Stop();

            }
            if (meueExpand5)
            {

                Categorymenu.Height = 42;
                meueExpand5 = false;
                Categorytimer.Stop();

            }
            if (meueExpand6)
            {

                Authormenu.Height = 42;
                meueExpand6 = false;
                Authortimer.Stop();

            }
            if (meueExpand7)
            {

                locationmenu.Height = 42;
                meueExpand7 = false;
                LocationTimer.Stop();

            }
        }

        private void Signout_Btn_Click(object sender, EventArgs e)
        {
            Forms.LogInSignUp.SignIn signin = new Forms.LogInSignUp.SignIn();
            this.Hide();
            signin.Show();
        }

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            if (rep == null)
            {
                rep = new Forms.Report.Report();
                rep.FormClosed += rep_FormClosed;
                rep.MdiParent = this;
                rep.Dock = DockStyle.Fill;
                rep.Show();

            }
            else
            {
                rep.Activate();
            }
        }

        private void rep_FormClosed(object sender, FormClosedEventArgs e)
        {
            rep.Activate();
        }
    }



}

