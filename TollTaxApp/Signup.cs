using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TollTaxApp
{
    public partial class SignupForm : Form
    {
        //StreamWriter writer = new StreamWriter("alluserdata.txt");
        Thread th;
        public SignupForm()
        {
            InitializeComponent();
        }

        // creating drop shadow
        private const int cs_shadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs_shadow;
                return cp;
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void closeImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "Username" || passtxt.Text == "Password" || string.IsNullOrEmpty(usertxt.Text) || string.IsNullOrEmpty(passtxt.Text))
            {
                DialogResult DR_defaultError = MessageBox.Show("Validation Erorr !\n\n1) *Fill all Fields.\n\n2) *Cannot have default Username and Password.", "ERROR!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (DR_defaultError == DialogResult.Retry)
                {
                    this.Close();
                    th = new Thread(againOpenSignup);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (DR_defaultError == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

            else
            {
                try
                {
                    // creating a reading stream (for checking the pre-created username)
                    StreamReader reader = new StreamReader(@"AllUserData//" + usertxt.Text + ".txt");
                    string username  = reader.ReadLine();

                    if (usertxt.Text.Equals(username))
                    {
                        MessageBox.Show("This Username is Taken !", "Erorr !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                    }
                }
                    
                catch(FileNotFoundException)
                {
                    
                    StreamWriter writer = new StreamWriter(@"AllUserData//" + usertxt.Text + ".txt");
                    writer.WriteLine(usertxt.Text);
                    writer.WriteLine(passtxt.Text);

                    writer.Flush();
                    writer.Close();

                    DialogResult DR_backToLogin = MessageBox.Show("New username and password created.\n\nNow you can Login.\n\nGo back to Login?", "SignUpDone!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (DR_backToLogin == DialogResult.Yes)
                    {
                        this.Close();
                        th = new Thread(redirectLoginForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

            }
        }

        private void redirectLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void againOpenSignup(object obj)
        {
            Application.Run(new SignupForm());
        }

        private void closeImg_MouseEnter(object sender, EventArgs e)
        {
            closeImg.Image = Image.FromFile(@"icons\\close.png");
        }

        private void closeImg_MouseLeave(object sender, EventArgs e)
        {
            closeImg.Image = Image.FromFile(@"icons\\close_black.png");
        }




    }
}
