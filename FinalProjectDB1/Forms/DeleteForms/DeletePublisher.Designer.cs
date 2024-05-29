namespace FinalProjectDB1.Forms.DeleteForms
{
    partial class DeletePublisher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ptype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.planguage = new ReaLTaiizor.DungeonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pname = new ReaLTaiizor.DungeonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pAdress = new System.Windows.Forms.RichTextBox();
            this.pemail = new ReaLTaiizor.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.Black;
            this.foxBigLabel1.Line = ReaLTaiizor.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(10, 10);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(497, 58);
            this.foxBigLabel1.TabIndex = 14;
            this.foxBigLabel1.Text = "DELETE PUBLISHER";
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.royalButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(119)))));
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.DarkCyan;
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(889, 295);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.DarkCyan;
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(124, 47);
            this.royalButton1.TabIndex = 5;
            this.royalButton1.Text = "DELETE";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 209);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ptype, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.planguage, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pAdress, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pemail, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 202);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            // 
            // ptype
            // 
            this.ptype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ptype.Items.AddRange(new object[] {
            "EBook",
            "Hardbook"});
            this.ptype.Location = new System.Drawing.Point(255, 88);
            this.ptype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptype.Name = "ptype";
            this.ptype.Size = new System.Drawing.Size(246, 24);
            this.ptype.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Publisher Language";
            // 
            // planguage
            // 
            this.planguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.planguage.BackColor = System.Drawing.Color.Transparent;
            this.planguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.planguage.EdgeColor = System.Drawing.Color.White;
            this.planguage.Font = new System.Drawing.Font("Tahoma", 11F);
            this.planguage.ForeColor = System.Drawing.Color.DimGray;
            this.planguage.Location = new System.Drawing.Point(759, 17);
            this.planguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planguage.MaxLength = 32767;
            this.planguage.Multiline = false;
            this.planguage.Name = "planguage";
            this.planguage.ReadOnly = false;
            this.planguage.Size = new System.Drawing.Size(246, 33);
            this.planguage.TabIndex = 9;
            this.planguage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.planguage.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publisher Name";
            // 
            // pname
            // 
            this.pname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pname.BackColor = System.Drawing.Color.Transparent;
            this.pname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pname.EdgeColor = System.Drawing.Color.White;
            this.pname.Font = new System.Drawing.Font("Tahoma", 11F);
            this.pname.ForeColor = System.Drawing.Color.DimGray;
            this.pname.Location = new System.Drawing.Point(255, 17);
            this.pname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pname.MaxLength = 32767;
            this.pname.Multiline = false;
            this.pname.Name = "pname";
            this.pname.ReadOnly = false;
            this.pname.Size = new System.Drawing.Size(246, 33);
            this.pname.TabIndex = 2;
            this.pname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pname.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Publisher Address";
            // 
            // pAdress
            // 
            this.pAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pAdress.Location = new System.Drawing.Point(759, 69);
            this.pAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAdress.Name = "pAdress";
            this.pAdress.Size = new System.Drawing.Size(246, 63);
            this.pAdress.TabIndex = 19;
            this.pAdress.Text = "";
            // 
            // pemail
            // 
            this.pemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pemail.BackColor = System.Drawing.Color.Transparent;
            this.pemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pemail.EdgeColor = System.Drawing.Color.White;
            this.pemail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.pemail.ForeColor = System.Drawing.Color.DimGray;
            this.pemail.Location = new System.Drawing.Point(255, 151);
            this.pemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pemail.MaxLength = 32767;
            this.pemail.Multiline = false;
            this.pemail.Name = "pemail";
            this.pemail.ReadOnly = false;
            this.pemail.Size = new System.Drawing.Size(246, 33);
            this.pemail.TabIndex = 27;
            this.pemail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pemail.UseSystemPasswordChar = false;
            // 
            // DeletePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1059, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.foxBigLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.royalButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePublisher";
            this.Text = "DeletePublisher";
            this.Load += new System.EventHandler(this.DeletePublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private ReaLTaiizor.RoyalButton royalButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ptype;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.DungeonTextBox planguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.DungeonTextBox pname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox pAdress;
        private ReaLTaiizor.DungeonTextBox pemail;
    }
}