namespace FinalProjectDB1.Forms.Staff_Section
{
    partial class BrowseBorrowBook
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
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.datatable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.SuspendLayout();
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.foxBigLabel1.Line = ReaLTaiizor.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(11, 11);
            this.foxBigLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(296, 45);
            this.foxBigLabel1.TabIndex = 30;
            this.foxBigLabel1.Text = "Borrowed Books";
            // 
            // datatable
            // 
            this.datatable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Location = new System.Drawing.Point(86, 145);
            this.datatable.Margin = new System.Windows.Forms.Padding(2);
            this.datatable.Name = "datatable";
            this.datatable.RowHeadersWidth = 51;
            this.datatable.RowTemplate.Height = 24;
            this.datatable.Size = new System.Drawing.Size(719, 249);
            this.datatable.TabIndex = 31;
            // 
            // BrowseBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 509);
            this.Controls.Add(this.datatable);
            this.Controls.Add(this.foxBigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowseBorrowBook";
            this.Text = "BrowseBorrowBook";
            this.Load += new System.EventHandler(this.BrowseBorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private System.Windows.Forms.DataGridView datatable;
    }
}