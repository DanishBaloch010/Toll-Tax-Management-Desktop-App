namespace TollTaxApp
{
    partial class AllRecordForm
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
            this.AllDriverDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closepicbox = new System.Windows.Forms.PictureBox();
            this.recordlbl = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllDriverDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllDriverDataGrid
            // 
            this.AllDriverDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllDriverDataGrid.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.AllDriverDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDriverDataGrid.Location = new System.Drawing.Point(11, 110);
            this.AllDriverDataGrid.Name = "AllDriverDataGrid";
            this.AllDriverDataGrid.Size = new System.Drawing.Size(1063, 407);
            this.AllDriverDataGrid.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(359, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Showing Existing All Driver Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TollTaxApp.Properties.Resources.update_arrows;
            this.pictureBox1.Location = new System.Drawing.Point(185, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // closepicbox
            // 
            this.closepicbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closepicbox.Image = global::TollTaxApp.Properties.Resources.close_black;
            this.closepicbox.Location = new System.Drawing.Point(1041, 12);
            this.closepicbox.Name = "closepicbox";
            this.closepicbox.Size = new System.Drawing.Size(33, 25);
            this.closepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepicbox.TabIndex = 10;
            this.closepicbox.TabStop = false;
            this.closepicbox.Click += new System.EventHandler(this.closepicbox_Click);
            this.closepicbox.MouseEnter += new System.EventHandler(this.closepicbox_MouseEnter);
            this.closepicbox.MouseLeave += new System.EventHandler(this.closepicbox_MouseLeave);
            // 
            // recordlbl
            // 
            this.recordlbl.AutoSize = true;
            this.recordlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordlbl.Location = new System.Drawing.Point(579, 520);
            this.recordlbl.Name = "recordlbl";
            this.recordlbl.Size = new System.Drawing.Size(0, 24);
            this.recordlbl.TabIndex = 13;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(455, 520);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(152, 24);
            this.lblCount.TabIndex = 14;
            this.lblCount.Text = "Total Records :";
            // 
            // AllRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1088, 562);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.recordlbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AllDriverDataGrid);
            this.Controls.Add(this.closepicbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllRecordForm";
            this.Load += new System.EventHandler(this.AllRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllDriverDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closepicbox;
        private System.Windows.Forms.DataGridView AllDriverDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label recordlbl;
        private System.Windows.Forms.Label lblCount;
    }
}