namespace TollTaxApp
{
    partial class SignupForm
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
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.passImg = new System.Windows.Forms.PictureBox();
            this.closeImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.passtxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(65, 185);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(219, 22);
            this.passtxt.TabIndex = 2;
            this.passtxt.Text = "Password";
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.usertxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usertxt.Location = new System.Drawing.Point(65, 83);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(219, 22);
            this.usertxt.TabIndex = 1;
            this.usertxt.Text = "Username";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signupBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signupBtn.Location = new System.Drawing.Point(108, 386);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(81, 28);
            this.signupBtn.TabIndex = 1;
            this.signupBtn.Text = "SignUp";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.userImg);
            this.panel1.Controls.Add(this.usertxt);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.passImg);
            this.panel1.Location = new System.Drawing.Point(-18, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 258);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Toll Tax\r\nManagement System\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TollTaxApp.Properties.Resources.tax1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // userImg
            // 
            this.userImg.Image = global::TollTaxApp.Properties.Resources.user1;
            this.userImg.Location = new System.Drawing.Point(126, 27);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(100, 50);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImg.TabIndex = 23;
            this.userImg.TabStop = false;
            // 
            // passImg
            // 
            this.passImg.Image = global::TollTaxApp.Properties.Resources._lock;
            this.passImg.Location = new System.Drawing.Point(126, 129);
            this.passImg.Name = "passImg";
            this.passImg.Size = new System.Drawing.Size(100, 50);
            this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passImg.TabIndex = 24;
            this.passImg.TabStop = false;
            // 
            // closeImg
            // 
            this.closeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeImg.Image = global::TollTaxApp.Properties.Resources.close_black;
            this.closeImg.Location = new System.Drawing.Point(276, 12);
            this.closeImg.Name = "closeImg";
            this.closeImg.Size = new System.Drawing.Size(28, 25);
            this.closeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImg.TabIndex = 25;
            this.closeImg.TabStop = false;
            this.closeImg.Click += new System.EventHandler(this.closeImg_Click);
            this.closeImg.MouseEnter += new System.EventHandler(this.closeImg_MouseEnter);
            this.closeImg.MouseLeave += new System.EventHandler(this.closeImg_MouseLeave);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.closeImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeImg;
        private System.Windows.Forms.PictureBox passImg;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}