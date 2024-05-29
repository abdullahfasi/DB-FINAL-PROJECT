namespace FinalProjectDB1.Forms.UpdateForms
{
    partial class UpdateBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bAbooks = new ReaLTaiizor.DungeonTextBox();
            this.bTcopies = new ReaLTaiizor.DungeonTextBox();
            this.bAuthor = new ReaLTaiizor.ComboBoxEdit();
            this.bEdition = new ReaLTaiizor.DungeonTextBox();
            this.bPublisher = new ReaLTaiizor.ComboBoxEdit();
            this.bTitle = new ReaLTaiizor.DungeonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bIsbn = new ReaLTaiizor.DungeonTextBox();
            this.bPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.bCategory = new ReaLTaiizor.ComboBoxEdit();
            this.Author = new System.Windows.Forms.Label();
            this.bLocation = new ReaLTaiizor.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 245);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.royalButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.LightBlue;
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(882, 12);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.LightBlue;
            this.royalButton1.PressedForeColor = System.Drawing.Color.White;
            this.royalButton1.Size = new System.Drawing.Size(149, 51);
            this.royalButton1.TabIndex = 16;
            this.royalButton1.Text = "UPDATE";
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
            this.foxBigLabel1.TabIndex = 25;
            this.foxBigLabel1.Text = "UPDATE BOOK";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.bAbooks, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.bTcopies, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bAuthor, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.bEdition, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bPublisher, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.bTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bIsbn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bPublicationDate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.bCategory, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Author, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.bLocation, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 330);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 281);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // bAbooks
            // 
            this.bAbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bAbooks.BackColor = System.Drawing.Color.Transparent;
            this.bAbooks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bAbooks.EdgeColor = System.Drawing.Color.White;
            this.bAbooks.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bAbooks.ForeColor = System.Drawing.Color.DimGray;
            this.bAbooks.Location = new System.Drawing.Point(768, 123);
            this.bAbooks.MaxLength = 32767;
            this.bAbooks.Multiline = false;
            this.bAbooks.Name = "bAbooks";
            this.bAbooks.ReadOnly = false;
            this.bAbooks.Size = new System.Drawing.Size(251, 33);
            this.bAbooks.TabIndex = 21;
            this.bAbooks.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bAbooks.UseSystemPasswordChar = false;
            // 
            // bTcopies
            // 
            this.bTcopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bTcopies.BackColor = System.Drawing.Color.Transparent;
            this.bTcopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTcopies.EdgeColor = System.Drawing.Color.White;
            this.bTcopies.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bTcopies.ForeColor = System.Drawing.Color.DimGray;
            this.bTcopies.Location = new System.Drawing.Point(768, 67);
            this.bTcopies.MaxLength = 32767;
            this.bTcopies.Multiline = false;
            this.bTcopies.Name = "bTcopies";
            this.bTcopies.ReadOnly = false;
            this.bTcopies.Size = new System.Drawing.Size(251, 33);
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
            this.bAuthor.Location = new System.Drawing.Point(768, 239);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(251, 26);
            this.bAuthor.StartIndex = 0;
            this.bAuthor.TabIndex = 24;
            // 
            // bEdition
            // 
            this.bEdition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdition.BackColor = System.Drawing.Color.Transparent;
            this.bEdition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bEdition.EdgeColor = System.Drawing.Color.White;
            this.bEdition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bEdition.ForeColor = System.Drawing.Color.DimGray;
            this.bEdition.Location = new System.Drawing.Point(768, 11);
            this.bEdition.MaxLength = 32767;
            this.bEdition.Multiline = false;
            this.bEdition.Name = "bEdition";
            this.bEdition.ReadOnly = false;
            this.bEdition.Size = new System.Drawing.Size(251, 33);
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
            this.bPublisher.Location = new System.Drawing.Point(258, 183);
            this.bPublisher.Name = "bPublisher";
            this.bPublisher.Size = new System.Drawing.Size(249, 26);
            this.bPublisher.StartIndex = 0;
            this.bPublisher.TabIndex = 18;
            // 
            // bTitle
            // 
            this.bTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bTitle.BackColor = System.Drawing.Color.Transparent;
            this.bTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTitle.EdgeColor = System.Drawing.Color.White;
            this.bTitle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bTitle.ForeColor = System.Drawing.Color.DimGray;
            this.bTitle.Location = new System.Drawing.Point(258, 11);
            this.bTitle.MaxLength = 32767;
            this.bTitle.Multiline = false;
            this.bTitle.Name = "bTitle";
            this.bTitle.ReadOnly = false;
            this.bTitle.Size = new System.Drawing.Size(249, 33);
            this.bTitle.TabIndex = 15;
            this.bTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bTitle.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(3, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "Publication date";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Book Title";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(3, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 27);
            this.label12.TabIndex = 3;
            this.label12.Text = "Publisher";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(3, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 27);
            this.label13.TabIndex = 5;
            this.label13.Text = "ISBN Code";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(513, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 27);
            this.label14.TabIndex = 6;
            this.label14.Text = "Book Edition ";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(513, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 27);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total Copies";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(513, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 27);
            this.label16.TabIndex = 8;
            this.label16.Text = "Available Copies";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(513, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 27);
            this.label17.TabIndex = 9;
            this.label17.Text = "Location";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(3, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 27);
            this.label18.TabIndex = 4;
            this.label18.Text = "Category";
            // 
            // bIsbn
            // 
            this.bIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bIsbn.BackColor = System.Drawing.Color.Transparent;
            this.bIsbn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bIsbn.EdgeColor = System.Drawing.Color.White;
            this.bIsbn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bIsbn.ForeColor = System.Drawing.Color.DimGray;
            this.bIsbn.Location = new System.Drawing.Point(258, 67);
            this.bIsbn.MaxLength = 32767;
            this.bIsbn.Multiline = false;
            this.bIsbn.Name = "bIsbn";
            this.bIsbn.ReadOnly = false;
            this.bIsbn.Size = new System.Drawing.Size(249, 33);
            this.bIsbn.TabIndex = 16;
            this.bIsbn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bIsbn.UseSystemPasswordChar = false;
            // 
            // bPublicationDate
            // 
            this.bPublicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bPublicationDate.Location = new System.Drawing.Point(258, 241);
            this.bPublicationDate.Name = "bPublicationDate";
            this.bPublicationDate.Size = new System.Drawing.Size(249, 22);
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
            this.bCategory.Location = new System.Drawing.Point(258, 127);
            this.bCategory.Name = "bCategory";
            this.bCategory.Size = new System.Drawing.Size(249, 26);
            this.bCategory.StartIndex = 0;
            this.bCategory.TabIndex = 18;
            // 
            // Author
            // 
            this.Author.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Author.Location = new System.Drawing.Point(513, 239);
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
            this.bLocation.Location = new System.Drawing.Point(768, 179);
            this.bLocation.MaxLength = 32767;
            this.bLocation.Multiline = false;
            this.bLocation.Name = "bLocation";
            this.bLocation.ReadOnly = true;
            this.bLocation.Size = new System.Drawing.Size(251, 33);
            this.bLocation.TabIndex = 21;
            this.bLocation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bLocation.UseSystemPasswordChar = false;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 632);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foxBigLabel1);
            this.Controls.Add(this.royalButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.RoyalButton royalButton1;
        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.DungeonTextBox bAbooks;
        private ReaLTaiizor.DungeonTextBox bTcopies;
        private ReaLTaiizor.ComboBoxEdit bAuthor;
        private ReaLTaiizor.DungeonTextBox bEdition;
        private ReaLTaiizor.ComboBoxEdit bPublisher;
        private ReaLTaiizor.DungeonTextBox bTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private ReaLTaiizor.DungeonTextBox bIsbn;
        private System.Windows.Forms.DateTimePicker bPublicationDate;
        private ReaLTaiizor.ComboBoxEdit bCategory;
        private System.Windows.Forms.Label Author;
        private ReaLTaiizor.DungeonTextBox bLocation;
    }
}