namespace FinalProjectDB1.Forms.Staff_Section
{
    partial class SearchBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new ReaLTaiizor.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEdit2 = new ReaLTaiizor.ComboBoxEdit();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.18182F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEdit1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEdit2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.royalButton1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 240);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search By";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBoxEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEdit1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEdit1.DropDownHeight = 100;
            this.comboBoxEdit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxEdit1.FormattingEnabled = true;
            this.comboBoxEdit1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboBoxEdit1.IntegralHeight = false;
            this.comboBoxEdit1.ItemHeight = 20;
            this.comboBoxEdit1.Items.AddRange(new object[] {
            "Title",
            "Publisher",
            "Category"});
            this.comboBoxEdit1.Location = new System.Drawing.Point(508, 27);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Size = new System.Drawing.Size(588, 26);
            this.comboBoxEdit1.StartIndex = 0;
            this.comboBoxEdit1.TabIndex = 51;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = " Search";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBoxEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEdit2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEdit2.DropDownHeight = 100;
            this.comboBoxEdit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxEdit2.FormattingEnabled = true;
            this.comboBoxEdit2.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboBoxEdit2.IntegralHeight = false;
            this.comboBoxEdit2.ItemHeight = 20;
            this.comboBoxEdit2.Location = new System.Drawing.Point(508, 107);
            this.comboBoxEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Size = new System.Drawing.Size(588, 26);
            this.comboBoxEdit2.StartIndex = 0;
            this.comboBoxEdit2.TabIndex = 51;
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
            this.royalButton1.Location = new System.Drawing.Point(974, 178);
            this.royalButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.MidnightBlue;
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(123, 44);
            this.royalButton1.TabIndex = 16;
            this.royalButton1.Text = "Search";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 356);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 257);
            this.dataGridView1.TabIndex = 33;
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
            this.foxBigLabel1.TabIndex = 32;
            this.foxBigLabel1.Text = "Search Book";
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foxBigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchBook";
            this.Text = "FineHandling";
            this.Load += new System.EventHandler(this.FineHandling_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.ComboBoxEdit comboBoxEdit2;
        private ReaLTaiizor.RoyalButton royalButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
    }
}