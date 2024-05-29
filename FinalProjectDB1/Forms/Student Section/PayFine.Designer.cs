namespace FinalProjectDB1.Forms.Student_Section
{
    partial class PayFine
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
            this.headerLabel1 = new ReaLTaiizor.HeaderLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tamount = new ReaLTaiizor.DungeonTextBox();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pamount = new ReaLTaiizor.DungeonTextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.ForeColor = System.Drawing.Color.Black;
            this.headerLabel1.Location = new System.Drawing.Point(13, 19);
            this.headerLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(202, 52);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "Pay Fine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.headerLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 85);
            this.panel1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.6811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.05118F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tamount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pamount, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 121);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 237);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tamount
            // 
            this.tamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tamount.BackColor = System.Drawing.Color.Transparent;
            this.tamount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tamount.EdgeColor = System.Drawing.Color.White;
            this.tamount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tamount.ForeColor = System.Drawing.Color.DimGray;
            this.tamount.Location = new System.Drawing.Point(341, 42);
            this.tamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tamount.MaxLength = 32767;
            this.tamount.Multiline = false;
            this.tamount.Name = "tamount";
            this.tamount.ReadOnly = true;
            this.tamount.Size = new System.Drawing.Size(386, 33);
            this.tamount.TabIndex = 28;
            this.tamount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tamount.UseSystemPasswordChar = false;
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.royalButton1.BackColor = System.Drawing.Color.LightSlateGray;
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.SlateGray;
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(934, 398);
            this.royalButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.SlateGray;
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(104, 44);
            this.royalButton1.TabIndex = 29;
            this.royalButton1.Text = "PAY";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pay Amount";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // pamount
            // 
            this.pamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pamount.BackColor = System.Drawing.Color.Transparent;
            this.pamount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pamount.EdgeColor = System.Drawing.Color.White;
            this.pamount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.pamount.ForeColor = System.Drawing.Color.DimGray;
            this.pamount.Location = new System.Drawing.Point(341, 161);
            this.pamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pamount.MaxLength = 32767;
            this.pamount.Multiline = false;
            this.pamount.Name = "pamount";
            this.pamount.ReadOnly = false;
            this.pamount.Size = new System.Drawing.Size(386, 33);
            this.pamount.TabIndex = 28;
            this.pamount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pamount.UseSystemPasswordChar = false;
            // 
            // PayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 580);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.royalButton1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PayFine";
            this.Text = "ViewPayedFine";
            this.Load += new System.EventHandler(this.PayFine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.HeaderLabel headerLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.DungeonTextBox tamount;
        private ReaLTaiizor.RoyalButton royalButton1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.DungeonTextBox pamount;
    }
}