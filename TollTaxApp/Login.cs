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
    public partial class LoginForm : Form
    {
        // globally declaring a thread 
        Thread th;

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
 
        // // creating drop shadow on login form 
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
        // 

        // close image code on login form 
        private void closeImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // changin close image picture with mouse enter an mouse leave events
        private void closeImg_MouseEnter(object sender, EventArgs e)
        {
            closeImg.Image = Image.FromFile(@"icons\\close.png");
        }

        private void closeImg_MouseLeave(object sender, EventArgs e)
        {
            closeImg.Image = Image.FromFile(@"icons\\close_black.png");
        }
        //

        // // signup button
        // closing login form and opening signup form in new thread
        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opensignupform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //

        // //methods created for each special case .to be used in threads
        private void opensignupform(object obj)
        {
            Application.Run(new SignupForm());
        }

        private void openloginform(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void opendriverdata(object obj)
        {
            Application.Run(new DriverData());
        }
        //

        //// login button
        // checking username and password both
        private void loginBtn_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader reader = new StreamReader(@"AllUserData//" + usertxt.Text + ".txt");
                string user = reader.ReadLine();
                string pass = reader.ReadLine();

                if (usertxt.Text.Equals(user) && passtxt.Text.Equals(pass))
                {
                        th = new Thread(opendriverdata);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Dispose();
                }
                else
                {
                    DialogResult DR_ErrorLogin = MessageBox.Show("Incorrect Username or Password!", "ERROR!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (DR_ErrorLogin == DialogResult.Retry)
                    {
                        this.Close();
                        th = new Thread(openloginform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    if (DR_ErrorLogin == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                }
            }


            catch (FileNotFoundException)
            {
                DialogResult DR_ErrorLogin = MessageBox.Show("Incorrect Username or Password!", "ERROR!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (DR_ErrorLogin == DialogResult.Retry)
                {
                    this.Close();
                    th = new Thread(openloginform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (DR_ErrorLogin == DialogResult.Cancel)   
                {
                    Application.Exit();
                }

            }

            //

        }

 


    }
}
    


