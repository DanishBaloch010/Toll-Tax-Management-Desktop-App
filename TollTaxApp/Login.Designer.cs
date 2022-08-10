namespace TollTaxApp
{
    partial class LoginForm
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
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passImg = new System.Windows.Forms.PictureBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.closeImg = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Create New User Account ";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signupBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signupBtn.Location = new System.Drawing.Point(207, 396);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(81, 28);
            this.signupBtn.TabIndex = 2;
            this.signupBtn.Text = "SignUp";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBtn.Location = new System.Drawing.Point(138, 227);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(81, 28);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.passtxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(64, 182);
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
            this.usertxt.Location = new System.Drawing.Point(64, 80);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(219, 22);
            this.usertxt.TabIndex = 1;
            this.usertxt.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.passImg);
            this.panel1.Controls.Add(this.userImg);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.usertxt);
            this.panel1.Location = new System.Drawing.Point(-18, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 270);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Toll Tax\r\nManagement System\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TollTaxApp.Properties.Resources.tax1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // passImg
            // 
            this.passImg.Image = global::TollTaxApp.Properties.Resources._lock;
            this.passImg.Location = new System.Drawing.Point(125, 126);
            this.passImg.Name = "passImg";
            this.passImg.Size = new System.Drawing.Size(100, 50);
            this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passImg.TabIndex = 19;
            this.passImg.TabStop = false;
            // 
            // userImg
            // 
            this.userImg.Image = global::TollTaxApp.Properties.Resources.user1;
            this.userImg.Location = new System.Drawing.Point(125, 24);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(100, 50);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImg.TabIndex = 18;
            this.userImg.TabStop = false;
            // 
            // closeImg
            // 
            this.closeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeImg.Image = global::TollTaxApp.Properties.Resources.close_black;
            this.closeImg.Location = new System.Drawing.Point(276, 12);
            this.closeImg.Name = "closeImg";
            this.closeImg.Size = new System.Drawing.Size(28, 25);
            this.closeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImg.TabIndex = 20;
            this.closeImg.TabStop = false;
            this.closeImg.Click += new System.EventHandler(this.closeImg_Click);
            this.closeImg.MouseEnter += new System.EventHandler(this.closeImg_MouseEnter);
            this.closeImg.MouseLeave += new System.EventHandler(this.closeImg_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(268, -41);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 14;
            this.closeBtn.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.closeImg);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.PictureBox closeImg;
        private System.Windows.Forms.PictureBox passImg;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

