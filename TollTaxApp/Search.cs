using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace TollTaxApp
{
    public partial class Search : Form
    {


        public Search()
        {
            InitializeComponent();

            nametxt.Visible = false;
            namelbl.Visible = false;
            phonenotxt.Visible = false;
            phonelbl.Visible = false;
            cnictxt.Visible = false;
            cniclbl.Visible = false;
            vehiclecategorytxt.Visible = false;
            vehiclecategorylbl.Visible = false;
            vehiclenametxt.Visible = false;
            vehiclenamelbl.Visible = false;
            passengerstxt.Visible = false;
            passengerlbl.Visible = false;
            fromcitytxt.Visible = false;
            fromcitylbl.Visible = false;
            tocitytxt.Visible = false;
            tocitylbl.Visible = false;
            tolltaxtxt.Visible = false;
            tolltaxlbl.Visible = false;


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

        private void closepicbox_MouseEnter(object sender, EventArgs e)
        {
            closepicbox.Image = Image.FromFile(@"icons\close.png");
        }

        private void closepicbox_MouseLeave(object sender, EventArgs e)
        {
            closepicbox.Image = Image.FromFile(@"icons\close_black.png");
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader reader = new StreamReader(@"AllDriverData_PhoneNumberwise//" + phonenoinputtxt.Text + ".txt");
                string driverid = reader.ReadLine();
                string name = reader.ReadLine();
                string phoneNumber = reader.ReadLine();
                string driverCnic = reader.ReadLine();
                string vehicleCateogry = reader.ReadLine();
                string vehicleName = reader.ReadLine();
                string fromCity = reader.ReadLine();
                string toCity = reader.ReadLine();
                string datetime = reader.ReadLine();
                string tollTax = reader.ReadLine();
                string passengers = reader.ReadLine();
                reader.Close();

                if(string.IsNullOrEmpty(nameinputtxt.Text) || string.IsNullOrEmpty(phonenoinputtxt.Text) || nameinputtxt.Text != name || phonenoinputtxt.Text != phoneNumber)
                {
                    nametxt.Visible = false;
                    namelbl.Visible = false;
                    phonenotxt.Visible = false;
                    phonelbl.Visible = false;
                    cnictxt.Visible = false;
                    cniclbl.Visible = false;
                    vehiclecategorytxt.Visible = false;
                    vehiclecategorylbl.Visible = false;
                    vehiclenametxt.Visible = false;
                    vehiclenamelbl.Visible = false;
                    passengerstxt.Visible = false;
                    passengerlbl.Visible = false;
                    fromcitytxt.Visible = false;
                    fromcitylbl.Visible = false;
                    tocitytxt.Visible = false;
                    tocitylbl.Visible = false;
                    tolltaxtxt.Visible = false;
                    tolltaxlbl.Visible = false;
                    MessageBox.Show("Invalid Entries in the Fields !!\n\n1) Fill all fields.*\n\n2) Check entered Data again.*", "Validation !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    nametxt.Visible = true;
                    namelbl.Visible = true;
                    phonenotxt.Visible = true;
                    phonelbl.Visible = true;
                    cnictxt.Visible = true;
                    cniclbl.Visible = true;
                    vehiclecategorytxt.Visible = true;
                    vehiclecategorylbl.Visible = true;
                    vehiclenametxt.Visible = true;
                    vehiclenamelbl.Visible = true;
                    passengerstxt.Visible = true;
                    passengerlbl.Visible = true;
                    fromcitytxt.Visible = true;
                    fromcitylbl.Visible = true;
                    tocitytxt.Visible = true;
                    tocitylbl.Visible = true;
                    tolltaxtxt.Visible = true;
                    tolltaxlbl.Visible = true;

                    nametxt.Text = name;
                    phonenotxt.Text = phoneNumber;
                    cnictxt.Text = driverCnic;
                    vehiclecategorytxt.Text = vehicleCateogry;
                    vehiclenametxt.Text = vehicleName;
                    fromcitytxt.Text = fromCity;
                    tocitytxt.Text = toCity;
                    tolltaxtxt.Text = tollTax;
                    passengerstxt.Text = passengers;

                    
                    
                }
            }

            catch (FileNotFoundException)
            {
                nametxt.Visible = false;
                namelbl.Visible = false;
                phonenotxt.Visible = false;
                phonelbl.Visible = false;
                cnictxt.Visible = false;
                cniclbl.Visible = false;
                vehiclecategorytxt.Visible = false;
                vehiclecategorylbl.Visible = false;
                vehiclenametxt.Visible = false;
                vehiclenamelbl.Visible = false;
                passengerstxt.Visible = false;
                passengerlbl.Visible = false;
                fromcitytxt.Visible = false;
                fromcitylbl.Visible = false;
                tocitytxt.Visible = false;
                tocitylbl.Visible = false;
                tolltaxtxt.Visible = false;
                tolltaxlbl.Visible = false;
                MessageBox.Show("Invalid Entries in the Fields !!\n\n1) Fill all fields.*\n\n2) Check entered Data again.*", "Validation !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }


        }

        private void Search_Load(object sender, EventArgs e)
        {

        }



    }
}
