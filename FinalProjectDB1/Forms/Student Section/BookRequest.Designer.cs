namespace FinalProjectDB1.Forms.Student_Section
{
    partial class BookRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel1 = new ReaLTaiizor.HeaderLabel();
            this.Ok = new ReaLTaiizor.Button();
            this.btitle = new ReaLTaiizor.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdText = new ReaLTaiizor.AloneTextBox();
            this.edcombo = new ReaLTaiizor.ComboBoxEdit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Name";
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.ForeColor = System.Drawing.Color.Black;
            this.headerLabel1.Location = new System.Drawing.Point(20, 25);
            this.headerLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(307, 52);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "Book Request";
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ok.Image = null;
            this.Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Ok.Location = new System.Drawing.Point(604, 283);
            this.Ok.Margin = new System.Windows.Forms.Padding(4);
            this.Ok.Name = "Ok";
            this.Ok.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Ok.Size = new System.Drawing.Size(180, 49);
            this.Ok.TabIndex = 18;
            this.Ok.Text = "Request";
            this.Ok.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // btitle
            // 
            this.btitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btitle.DropDownHeight = 100;
            this.btitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btitle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btitle.FormattingEnabled = true;
            this.btitle.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btitle.IntegralHeight = false;
            this.btitle.ItemHeight = 20;
            this.btitle.Location = new System.Drawing.Point(398, 33);
            this.btitle.Margin = new System.Windows.Forms.Padding(4);
            this.btitle.Name = "btitle";
            this.btitle.Size = new System.Drawing.Size(386, 26);
            this.btitle.StartIndex = 0;
            this.btitle.TabIndex = 13;
            this.btitle.SelectedIndexChanged += new System.EventHandler(this.btitle_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.headerLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 95);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ok, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stdText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.edcombo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(208, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 375);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editions";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Student Name";
            // 
            // stdText
            // 
            this.stdText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stdText.BackColor = System.Drawing.Color.White;
            this.stdText.Cursor = System.Windows.Forms.Cursors.No;
            this.stdText.EnabledCalc = true;
            this.stdText.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stdText.Location = new System.Drawing.Point(401, 214);
            this.stdText.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stdText.MaxLength = 32767;
            this.stdText.MultiLine = false;
            this.stdText.Name = "stdText";
            this.stdText.Padding = new System.Windows.Forms.Padding(13, 6, 7, 6);
            this.stdText.ReadOnly = true;
            this.stdText.Size = new System.Drawing.Size(380, 36);
            this.stdText.TabIndex = 19;
            this.stdText.Text = "Username";
            this.stdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdText.UseSystemPasswordChar = false;
            // 
            // edcombo
            // 
            this.edcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.edcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.edcombo.DropDownHeight = 100;
            this.edcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edcombo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.edcombo.FormattingEnabled = true;
            this.edcombo.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.edcombo.IntegralHeight = false;
            this.edcombo.ItemHeight = 20;
            this.edcombo.Location = new System.Drawing.Point(398, 126);
            this.edcombo.Margin = new System.Windows.Forms.Padding(4);
            this.edcombo.Name = "edcombo";
            this.edcombo.Size = new System.Drawing.Size(386, 26);
            this.edcombo.StartIndex = 0;
            this.edcombo.TabIndex = 13;
            // 
            // BookRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1185, 764);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookRequest";
            this.Text = "BookRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.HeaderLabel headerLabel1;
        private ReaLTaiizor.Button Ok;
        private ReaLTaiizor.ComboBoxEdit btitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.AloneTextBox stdText;
        private ReaLTaiizor.ComboBoxEdit edcombo;
    }
}