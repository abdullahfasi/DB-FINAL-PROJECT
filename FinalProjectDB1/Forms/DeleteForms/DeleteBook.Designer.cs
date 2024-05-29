namespace FinalProjectDB1.Forms.DeleteForms
{
    partial class DeleteBook
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
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bAbooks = new ReaLTaiizor.DungeonTextBox();
            this.bTcopies = new ReaLTaiizor.DungeonTextBox();
            this.bAuthor = new ReaLTaiizor.ComboBoxEdit();
            this.bEdition = new ReaLTaiizor.DungeonTextBox();
            this.bPublisher = new ReaLTaiizor.ComboBoxEdit();
            this.bTitle = new ReaLTaiizor.DungeonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bIsbn = new ReaLTaiizor.DungeonTextBox();
            this.bPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.bCategory = new ReaLTaiizor.ComboBoxEdit();
            this.Author = new System.Windows.Forms.Label();
            this.bLocation = new ReaLTaiizor.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.royalButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.Teal;
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(930, 12);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.Teal;
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(131, 51);
            this.royalButton1.TabIndex = 16;
            this.royalButton1.Text = "DELETE";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click);
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.foxBigLabel1.Line = ReaLTaiizor.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(12, 12);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(307, 52);
            this.foxBigLabel1.TabIndex = 18;
            this.foxBigLabel1.Text = "DELETE BOOK";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 261);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bAbooks, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bTcopies, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bAuthor, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.bEdition, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bPublisher, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bIsbn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bPublicationDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Author, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bLocation, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 274);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // bAbooks
            // 
            this.bAbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bAbooks.BackColor = System.Drawing.Color.Transparent;
            this.bAbooks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bAbooks.EdgeColor = System.Drawing.Color.White;
            this.bAbooks.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bAbooks.ForeColor = System.Drawing.Color.DimGray;
            this.bAbooks.Location = new System.Drawing.Point(798, 118);
            this.bAbooks.MaxLength = 32767;
            this.bAbooks.Multiline = false;
            this.bAbooks.Name = "bAbooks";
            this.bAbooks.ReadOnly = true;
            this.bAbooks.Size = new System.Drawing.Size(260, 33);
            this.bAbooks.TabIndex = 21;
            this.bAbooks.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bAbooks.UseSystemPasswordChar = false;
            // 
            // bTcopies
            // 
            this.bTcopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bTcopies.BackColor = System.Drawing.Color.Transparent;
            this.bTcopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTcopies.EdgeColor = System.Drawing.Color.Transparent;
            this.bTcopies.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bTcopies.ForeColor = System.Drawing.Color.DimGray;
            this.bTcopies.Location = new System.Drawing.Point(798, 64);
            this.bTcopies.MaxLength = 32767;
            this.bTcopies.Multiline = false;
            this.bTcopies.Name = "bTcopies";
            this.bTcopies.ReadOnly = true;
            this.bTcopies.Size = new System.Drawing.Size(260, 33);
            this.bTcopies.TabIndex = 20;
            this.bTcopies.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bTcopies.UseSystemPasswordChar = false;
            // 
            // bAuthor
            // 
            this.bAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.bAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bAuthor.DropDownHeight = 100;
            this.bAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bAuthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bAuthor.ForeColor = System.Drawing.Color.Black;
            this.bAuthor.FormattingEnabled = true;
            this.bAuthor.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bAuthor.IntegralHeight = false;
            this.bAuthor.ItemHeight = 20;
            this.bAuthor.Location = new System.Drawing.Point(798, 232);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(260, 26);
            this.bAuthor.StartIndex = 0;
            this.bAuthor.TabIndex = 24;
            // 
            // bEdition
            // 
            this.bEdition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdition.BackColor = System.Drawing.Color.Transparent;
            this.bEdition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bEdition.EdgeColor = System.Drawing.Color.Transparent;
            this.bEdition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bEdition.ForeColor = System.Drawing.Color.DimGray;
            this.bEdition.Location = new System.Drawing.Point(798, 10);
            this.bEdition.MaxLength = 32767;
            this.bEdition.Multiline = false;
            this.bEdition.Name = "bEdition";
            this.bEdition.ReadOnly = true;
            this.bEdition.Size = new System.Drawing.Size(260, 33);
            this.bEdition.TabIndex = 19;
            this.bEdition.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bEdition.UseSystemPasswordChar = false;
            // 
            // bPublisher
            // 
            this.bPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.bPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bPublisher.DropDownHeight = 100;
            this.bPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bPublisher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bPublisher.ForeColor = System.Drawing.Color.Black;
            this.bPublisher.FormattingEnabled = true;
            this.bPublisher.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bPublisher.IntegralHeight = false;
            this.bPublisher.ItemHeight = 20;
            this.bPublisher.Location = new System.Drawing.Point(268, 176);
            this.bPublisher.Name = "bPublisher";
            this.bPublisher.Size = new System.Drawing.Size(259, 26);
            this.bPublisher.StartIndex = 0;
            this.bPublisher.TabIndex = 18;
            // 
            // bTitle
            // 
            this.bTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bTitle.BackColor = System.Drawing.Color.Transparent;
            this.bTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTitle.EdgeColor = System.Drawing.Color.Transparent;
            this.bTitle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bTitle.ForeColor = System.Drawing.Color.DimGray;
            this.bTitle.Location = new System.Drawing.Point(268, 10);
            this.bTitle.MaxLength = 32767;
            this.bTitle.Multiline = false;
            this.bTitle.Name = "bTitle";
            this.bTitle.ReadOnly = true;
            this.bTitle.Size = new System.Drawing.Size(259, 33);
            this.bTitle.TabIndex = 15;
            this.bTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bTitle.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Publication date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "ISBN Code";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(533, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Book Edition ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(533, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Copies";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(533, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Available Copies";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(533, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Location";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // bIsbn
            // 
            this.bIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bIsbn.BackColor = System.Drawing.Color.Transparent;
            this.bIsbn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bIsbn.EdgeColor = System.Drawing.Color.Transparent;
            this.bIsbn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bIsbn.ForeColor = System.Drawing.Color.DimGray;
            this.bIsbn.Location = new System.Drawing.Point(268, 64);
            this.bIsbn.MaxLength = 32767;
            this.bIsbn.Multiline = false;
            this.bIsbn.Name = "bIsbn";
            this.bIsbn.ReadOnly = true;
            this.bIsbn.Size = new System.Drawing.Size(259, 33);
            this.bIsbn.TabIndex = 16;
            this.bIsbn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bIsbn.UseSystemPasswordChar = false;
            // 
            // bPublicationDate
            // 
            this.bPublicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bPublicationDate.Location = new System.Drawing.Point(268, 234);
            this.bPublicationDate.Name = "bPublicationDate";
            this.bPublicationDate.Size = new System.Drawing.Size(259, 22);
            this.bPublicationDate.TabIndex = 15;
            // 
            // bCategory
            // 
            this.bCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.bCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bCategory.DropDownHeight = 100;
            this.bCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bCategory.ForeColor = System.Drawing.Color.Black;
            this.bCategory.FormattingEnabled = true;
            this.bCategory.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bCategory.IntegralHeight = false;
            this.bCategory.ItemHeight = 20;
            this.bCategory.Location = new System.Drawing.Point(268, 122);
            this.bCategory.Name = "bCategory";
            this.bCategory.Size = new System.Drawing.Size(259, 26);
            this.bCategory.StartIndex = 0;
            this.bCategory.TabIndex = 18;
            // 
            // Author
            // 
            this.Author.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Author.Location = new System.Drawing.Point(533, 231);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(89, 27);
            this.Author.TabIndex = 23;
            this.Author.Text = "Author";
            // 
            // bLocation
            // 
            this.bLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bLocation.BackColor = System.Drawing.Color.Transparent;
            this.bLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bLocation.EdgeColor = System.Drawing.Color.White;
            this.bLocation.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bLocation.ForeColor = System.Drawing.Color.DimGray;
            this.bLocation.Location = new System.Drawing.Point(798, 172);
            this.bLocation.MaxLength = 32767;
            this.bLocation.Multiline = false;
            this.bLocation.Name = "bLocation";
            this.bLocation.ReadOnly = true;
            this.bLocation.Size = new System.Drawing.Size(260, 33);
            this.bLocation.TabIndex = 21;
            this.bLocation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bLocation.UseSystemPasswordChar = false;
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.royalButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foxBigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.RoyalButton royalButton1;
        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.DungeonTextBox bAbooks;
        private ReaLTaiizor.DungeonTextBox bTcopies;
        private ReaLTaiizor.ComboBoxEdit bAuthor;
        private ReaLTaiizor.DungeonTextBox bEdition;
        private ReaLTaiizor.ComboBoxEdit bPublisher;
        private ReaLTaiizor.DungeonTextBox bTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.DungeonTextBox bIsbn;
        private System.Windows.Forms.DateTimePicker bPublicationDate;
        private ReaLTaiizor.ComboBoxEdit bCategory;
        private System.Windows.Forms.Label Author;
        private ReaLTaiizor.DungeonTextBox bLocation;
    }
}