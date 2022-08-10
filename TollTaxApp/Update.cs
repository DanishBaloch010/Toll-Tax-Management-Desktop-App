using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TollTaxApp
{
    public partial class Update : Form
    {

        public Update()
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
            updatebtn.Visible = false;
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

        private void showdatabtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"AllDriverData_IDwise//" + idtxt.Text + ".txt");
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

                idtxt.ReadOnly = true;

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
                updatebtn.Visible = true;

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

            catch (FileNotFoundException)
            {
                MessageBox.Show("This ID does not belong to anyone!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                idtxt.ReadOnly = false;

                idtxt.Text = null;
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
                updatebtn.Visible = false;

                idtxt.Focus();


            }


        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"AllDriverData//" + idtxt.Text + ".txt");
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

                if (nametxt.Text == name && phonenotxt.Text == phoneNumber && cnictxt.Text == driverCnic && vehiclecategorytxt.Text == vehicleCateogry && vehiclenametxt.Text == vehicleName && passengerstxt.Text == passengers && fromcitytxt.Text == fromCity && tocitytxt.Text == toCity && tolltaxtxt.Text == tollTax)
                {
                    DialogResult DR = MessageBox.Show("Do you want to save data without changes ?", "UPDATE!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        StreamWriter writer = new StreamWriter(@"AllDriverData//" + idtxt.Text + ".txt");
                        writer.WriteLine(driverid);
                        writer.WriteLine(nametxt.Text);
                        writer.WriteLine(phonenotxt.Text);
                        writer.WriteLine(cnictxt.Text);
                        writer.WriteLine(vehiclecategorytxt.Text);
                        writer.WriteLine(vehiclenametxt.Text);
                        writer.WriteLine(fromcitytxt.Text);
                        writer.WriteLine(tocitytxt.Text);
                        writer.WriteLine(datetime);
                        writer.WriteLine(tolltaxtxt.Text);
                        writer.WriteLine(passengerstxt.Text);
                        writer.Close();

                        idtxt.ReadOnly = false;

                        idtxt.Text = null;
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
                        updatebtn.Visible = false;

                    }


                }

                else
                {

                    StreamWriter writer = new StreamWriter(@"AllDriverData//" + idtxt.Text + ".txt");
                    writer.WriteLine(driverid);
                    writer.WriteLine(nametxt.Text);
                    writer.WriteLine(phonenotxt.Text);
                    writer.WriteLine(cnictxt.Text);
                    writer.WriteLine(vehiclecategorytxt.Text);
                    writer.WriteLine(vehiclenametxt.Text);
                    writer.WriteLine(fromcitytxt.Text);
                    writer.WriteLine(tocitytxt.Text);
                    writer.WriteLine(datetime);
                    writer.WriteLine(tolltaxtxt.Text);
                    writer.WriteLine(passengerstxt.Text);
                    writer.Close();

                    StreamWriter writerPhoneNo = new StreamWriter(@"AllDriverDataPhoneNumber//" + phoneNumber + ".txt");
                    writerPhoneNo.WriteLine(driverid);
                    writerPhoneNo.WriteLine(nametxt.Text);
                    writerPhoneNo.WriteLine(phonenotxt.Text);
                    writerPhoneNo.WriteLine(cnictxt.Text);
                    writerPhoneNo.WriteLine(vehiclecategorytxt.Text);
                    writerPhoneNo.WriteLine(vehiclenametxt.Text);
                    writerPhoneNo.WriteLine(fromcitytxt.Text);
                    writerPhoneNo.WriteLine(tocitytxt.Text);
                    writerPhoneNo.WriteLine(datetime);
                    writerPhoneNo.WriteLine(tolltaxtxt.Text);
                    writerPhoneNo.WriteLine(passengerstxt.Text);
                    writerPhoneNo.Close();

                    DialogResult DR = MessageBox.Show("Done with the updates ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        idtxt.ReadOnly = false;

                        idtxt.Text = null;
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
                        updatebtn.Visible = false;

                        MessageBox.Show("Data is safely saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("This ID does not belong to anyone!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                idtxt.ReadOnly = false;

                idtxt.Text = null;
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
                updatebtn.Visible = false;
                
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}