namespace FinalProjectDB1.Forms.Staff_Section
{
    partial class BookIssuance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadbutton = new ReaLTaiizor.RoyalButton();
            this.label7 = new System.Windows.Forms.Label();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studenttextbox = new System.Windows.Forms.TextBox();
            this.booktextbox = new System.Windows.Forms.TextBox();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.staffid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.issuebooktable = new System.Windows.Forms.DataGridView();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.datafromrequesttable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooktable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datafromrequesttable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.loadbutton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.studenttextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.booktextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.returndate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.royalButton1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 282);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // loadbutton
            // 
            this.loadbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadbutton.BackColor = System.Drawing.Color.DarkBlue;
            this.loadbutton.BorderColor = System.Drawing.Color.Transparent;
            this.loadbutton.BorderThickness = 3;
            this.loadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadbutton.DrawBorder = true;
            this.loadbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbutton.ForeColor = System.Drawing.Color.White;
            this.loadbutton.HotTrackColor = System.Drawing.Color.MidnightBlue;
            this.loadbutton.Image = null;
            this.loadbutton.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.loadbutton.Location = new System.Drawing.Point(478, 224);
            this.loadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.PressedColor = System.Drawing.Color.MidnightBlue;
            this.loadbutton.PressedForeColor = System.Drawing.Color.Black;
            this.loadbutton.Size = new System.Drawing.Size(123, 44);
            this.loadbutton.TabIndex = 59;
            this.loadbutton.Text = "Load Data";
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(4, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Size = new System.Drawing.Size(146, 30);
            this.label7.TabIndex = 54;
            this.label7.Text = "Return Date";
            // 
            // returndate
            // 
            this.returndate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.returndate.Location = new System.Drawing.Point(204, 164);
            this.returndate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(195, 22);
            this.returndate.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(4, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Student";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book";
            // 
            // studenttextbox
            // 
            this.studenttextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studenttextbox.Location = new System.Drawing.Point(205, 24);
            this.studenttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.studenttextbox.Name = "studenttextbox";
            this.studenttextbox.ReadOnly = true;
            this.studenttextbox.Size = new System.Drawing.Size(193, 22);
            this.studenttextbox.TabIndex = 57;
            // 
            // booktextbox
            // 
            this.booktextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.booktextbox.Location = new System.Drawing.Point(205, 94);
            this.booktextbox.Margin = new System.Windows.Forms.Padding(4);
            this.booktextbox.Name = "booktextbox";
            this.booktextbox.ReadOnly = true;
            this.booktextbox.Size = new System.Drawing.Size(193, 22);
            this.booktextbox.TabIndex = 58;
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.royalButton1.BackColor = System.Drawing.Color.DarkBlue;
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.MidnightBlue;
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(478, 153);
            this.royalButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.MidnightBlue;
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(123, 44);
            this.royalButton1.TabIndex = 16;
            this.royalButton1.Text = "Issue";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click_1);
            // 
            // staffid
            // 
            this.staffid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.staffid.AutoSize = true;
            this.staffid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffid.ForeColor = System.Drawing.Color.DarkBlue;
            this.staffid.Location = new System.Drawing.Point(1113, 16);
            this.staffid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffid.Name = "staffid";
            this.staffid.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffid.Size = new System.Drawing.Size(31, 30);
            this.staffid.TabIndex = 58;
            this.staffid.Text = "6";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(1001, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 57;
            this.label3.Text = "Staff ID";
            // 
            // issuebooktable
            // 
            this.issuebooktable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuebooktable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuebooktable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issuebooktable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuebooktable.Location = new System.Drawing.Point(37, 395);
            this.issuebooktable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issuebooktable.Name = "issuebooktable";
            this.issuebooktable.RowHeadersWidth = 51;
            this.issuebooktable.RowTemplate.Height = 24;
            this.issuebooktable.Size = new System.Drawing.Size(1131, 215);
            this.issuebooktable.TabIndex = 30;
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.foxBigLabel1.Line = ReaLTaiizor.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(37, 16);
            this.foxBigLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(339, 52);
            this.foxBigLabel1.TabIndex = 29;
            this.foxBigLabel1.Text = "Issue Book";
            // 
            // datafromrequesttable
            // 
            this.datafromrequesttable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datafromrequesttable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datafromrequesttable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datafromrequesttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datafromrequesttable.Location = new System.Drawing.Point(739, 90);
            this.datafromrequesttable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datafromrequesttable.Name = "datafromrequesttable";
            this.datafromrequesttable.RowHeadersWidth = 51;
            this.datafromrequesttable.RowTemplate.Height = 24;
            this.datafromrequesttable.Size = new System.Drawing.Size(429, 282);
            this.datafromrequesttable.TabIndex = 59;
            this.datafromrequesttable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datafromrequesttable_CellClick);
            // 
            // BookIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 626);
            this.Controls.Add(this.datafromrequesttable);
            this.Controls.Add(this.staffid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.issuebooktable);
            this.Controls.Add(this.foxBigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookIssuance";
            this.Text = "BookIssuance";
            this.Load += new System.EventHandler(this.BookIssuance_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooktable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datafromrequesttable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label staffid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker returndate;
        private ReaLTaiizor.RoyalButton royalButton1;
        private System.Windows.Forms.DataGridView issuebooktable;
        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private System.Windows.Forms.DataGridView datafromrequesttable;
        private System.Windows.Forms.TextBox studenttextbox;
        private System.Windows.Forms.TextBox booktextbox;
        private ReaLTaiizor.RoyalButton loadbutton;
    }
}