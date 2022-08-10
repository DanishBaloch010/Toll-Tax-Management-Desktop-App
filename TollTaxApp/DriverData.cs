using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Data.Sql;
namespace TollTaxApp
{
    public partial class DriverData : Form
    {
        public DriverData()
        {
            InitializeComponent();
            DriverDataGrid.Columns.Add("A", "AID");
            DriverDataGrid.Columns.Add("B", "DriverName");
            DriverDataGrid.Columns.Add("C", "Phone Number");
            DriverDataGrid.Columns.Add("D", "DriverCNIC");
            DriverDataGrid.Columns.Add("E", "Vehicle Category");
            DriverDataGrid.Columns.Add("F", "CrossingVehicle");
            DriverDataGrid.Columns.Add("G", "FromCity");
            DriverDataGrid.Columns.Add("H", "ToCity");
            DriverDataGrid.Columns.Add("I", "TravelDate");
            DriverDataGrid.Columns.Add("J", "TollTax");
            DriverDataGrid.Columns.Add("K", "Passengers");

            DriverDataGrid.Columns[0].Width = 50;
            DriverDataGrid.Columns[1].Width = 100;
            DriverDataGrid.Columns[2].Width = 100;
            DriverDataGrid.Columns[3].Width = 110;
            DriverDataGrid.Columns[4].Width = 100;
            DriverDataGrid.Columns[5].Width = 100;
            DriverDataGrid.Columns[6].Width = 100;
            DriverDataGrid.Columns[7].Width = 70;
            DriverDataGrid.Columns[8].Width = 160;
            DriverDataGrid.Columns[9].Width = 55;
            DriverDataGrid.Columns[10].Width = 75;
            GetTax();


            StreamReader IDreader = new StreamReader(@"Driver_ID//uniqueID.txt");
            string AID = IDreader.ReadLine();
            IDreader.Close();

            driverCounter = int.Parse(AID);

            customdesign();

        }

        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        SqlCommand cmd;

        DataSet ds;
        DataTable dt;
        DataRow dr;



        // customizing a drop down menu 
        private void customdesign()
        {
            SubmenumoreOptions.Visible = false;
        }

        private void hideSubMenu()
        {
            if (SubmenumoreOptions.Visible == true)
                SubmenumoreOptions.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }

            else {
                subMenu.Visible = false;
            }
        }

        private void optionbtn_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenumoreOptions);
        }
        //xx customizing a drop shadow


        private void GetTax()
        {
            AutoCompleteStringCollection Arr = new AutoCompleteStringCollection();
            StreamReader SR = new StreamReader("TAXdata.txt");
            while (!SR.EndOfStream)
            {
                Arr.Add(SR.ReadLine());
            }
            
            SR.Close();
            vehciletxt.AutoCompleteCustomSource = Arr;
            vehciletxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            vehciletxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void vehciletxt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                 string[] A = vehciletxt.Text.Split('#');
                 vehciletxt.Text = A[0];
                 tolltaxlbl.Text=A[1];
                 vehiclenametxt.Focus();
            }
        }

        int driverCounter = 0;

        private void markbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(phonetxt.Text)|| string.IsNullOrEmpty(cnictxt.Text) || string.IsNullOrEmpty(vehciletxt.Text) || string.IsNullOrEmpty(vehiclenametxt.Text) || string.IsNullOrEmpty(FromCitytxt.Text) || string.IsNullOrEmpty(ToCItytxt.Text) || string.IsNullOrEmpty(passengertxt.Text))
            {
                MessageBox.Show("Insert Proper Data !!", "ERORR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DriverDataGrid.Rows.Add(driveridlbl.Text, nametxt.Text, phonetxt.Text, cnictxt.Text, vehciletxt.Text, vehiclenametxt.Text, FromCitytxt.Text, ToCItytxt.Text, DateTime.Now.ToString(), tolltaxlbl.Text, passengertxt.Text);
                driveridlbl.Text = driverCounter.ToString();
            }
        }


        private void DriverData_Load(object sender, EventArgs e)
        {
            driveridlbl.Text = driverCounter.ToString();
            //con = new SqlConnection(@"Data Source=AlexanderAnjelo\sqlexpress;Initial Catalog=TaxAppDB;Integrated Security=True;Pooling=False");
            //adp = new SqlDataAdapter();
            //ds = new DataSet();
        }

        private void savedataBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(phonetxt.Text) || string.IsNullOrEmpty(cnictxt.Text) || string.IsNullOrEmpty(vehciletxt.Text) || string.IsNullOrEmpty(vehiclenametxt.Text) || string.IsNullOrEmpty(FromCitytxt.Text) || string.IsNullOrEmpty(ToCItytxt.Text) || string.IsNullOrEmpty(passengertxt.Text))
            {
                MessageBox.Show("Insert Proper Data !!", "ERORR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = nametxt.Text;
                string phonenum = phonetxt.Text;

                //making files of every driver and writing data (line by line)
                StreamWriter writerAllDriverData = new StreamWriter(@"AllDriverData_IDwise//" + driveridlbl.Text + ".txt");
                StreamWriter writerAllDriverDataPhoneNumber = new StreamWriter(@"AllDriverData_PhoneNumberwise//" +phonetxt.Text + ".txt");
                writerAllDriverData.WriteLine(driveridlbl.Text);
                writerAllDriverData.WriteLine(nametxt.Text);
                writerAllDriverData.WriteLine(phonetxt.Text);
                writerAllDriverData.WriteLine(cnictxt.Text);
                writerAllDriverData.WriteLine(vehciletxt.Text);
                writerAllDriverData.WriteLine(vehiclenametxt.Text);
                writerAllDriverData.WriteLine(FromCitytxt.Text);
                writerAllDriverData.WriteLine(ToCItytxt.Text);
                writerAllDriverData.WriteLine(DateTime.Now.ToString());
                writerAllDriverData.WriteLine(tolltaxlbl.Text);
                writerAllDriverData.WriteLine(passengertxt.Text);

                writerAllDriverDataPhoneNumber.WriteLine(driveridlbl.Text);
                writerAllDriverDataPhoneNumber.WriteLine(nametxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(phonetxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(cnictxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(vehciletxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(vehiclenametxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(FromCitytxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(ToCItytxt.Text);
                writerAllDriverDataPhoneNumber.WriteLine(DateTime.Now.ToString());
                writerAllDriverDataPhoneNumber.WriteLine(tolltaxlbl.Text);
                writerAllDriverDataPhoneNumber.WriteLine(passengertxt.Text);
                writerAllDriverData.Close();
                writerAllDriverDataPhoneNumber.Close();

                // appending all data
                StreamWriter writerDriverData = new StreamWriter("alldriverdata.txt", true);
                // directly writing all data into a file 
                writerDriverData.WriteLine(driveridlbl.Text + "#" + nametxt.Text + "#" + phonetxt.Text + "#" + cnictxt.Text + "#" + vehciletxt.Text + "#" + vehiclenametxt.Text + "#" + FromCitytxt.Text + "#" + ToCItytxt.Text + "#" + DateTime.Now.ToString() + "#" + tolltaxlbl.Text + "#" + passengertxt.Text);
                writerDriverData.Close();
                //con.Open();
                //string sql = "Insert Into TestTable1(name,phone) values(\""+name+"\""+","+"\""+phonenum+"\")";
                //string sql = "Insert Into TestTable1(name,phone) values(@Name,@phonenum)";
                //MessageBox.Show(sql);
                //cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@Name",name);
                //cmd.Parameters.AddWithValue("@phonenum", phonenum);
                //cmd.ExecuteNonQuery();
                //con.Open();
                //adp.InsertCommand = new SqlCommand(sql,con);
                //adp.ExecuteNonQuery();
                //clear all the input boxes** after saving them into files
                nametxt.Text = null;
                phonetxt.Text = null;
                cnictxt.Text = null;
                vehciletxt.Text = null;
                vehiclenametxt.Text = null;
                FromCitytxt.Text = null;
                ToCItytxt.Text = null;
                passengertxt.Text = null;

  

                driverCounter++;
                
                StreamWriter IDwriter = new StreamWriter(@"Driver_ID//uniqueID.txt");
                IDwriter.WriteLine(driverCounter);
                IDwriter.Close();

                driveridlbl.Text = driverCounter.ToString();
                tolltaxlbl.Text ="No Data";
                nametxt.Focus();
            }

        }
        
        Update updateform;
        Search searchform;
        AllRecordForm allrecordform;

        // search button form opening 
        private void searchbtn_Click(object sender, EventArgs e)
        {

            if (searchform == null)
            {
                searchform = new Search();
                searchform.FormClosed += new FormClosedEventHandler(searchform_FormClosed);
                searchform.TopLevel = true;
                searchform.ShowDialog();
            }
            else
            {
                searchform.Activate();
            }
        }

        void searchform_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchform = null;
        }
        //xx // search button form opening 

        // update button form opening 
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (updateform == null)
            {
                updateform = new Update();
                updateform.FormClosed += new FormClosedEventHandler(updateform_FormClosed);
                updateform.TopLevel = true;
                updateform.ShowDialog();

            }

            else
            {

                updateform.Activate();
            }

        }
        
        void updateform_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateform = null;
        }
        //xx // update button form opening 


        // view records button form opening 
        private void viewRecordsbtn_Click(object sender, EventArgs e)
        {
            if (allrecordform == null)
            {
                allrecordform = new AllRecordForm();
                allrecordform.FormClosed += new FormClosedEventHandler(allrecordform_FormClosed);
                allrecordform.TopLevel = true;
                allrecordform.ShowDialog();

            }

            else
            {

                allrecordform.Activate();
            }
        }

        void allrecordform_FormClosed(object sender, FormClosedEventArgs e)
        {
            allrecordform = null;
        }
        //xx // view records button form opening 

        // exit button code
        private void exitbtn_MouseEnter(object sender, EventArgs e)
        {
            exitbtn.BackgroundImage= Image.FromFile(@"icons\exit_red.png");
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.BackgroundImage = Image.FromFile(@"icons\exit.png");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure you want to exit ?","EXIT",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if(DR==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //xx // exit button code


        private void DriverDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to delete this driver data.", "Delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                int rowNumber = DriverDataGrid.CurrentCell.RowIndex;
                DriverDataGrid.Rows.RemoveAt(rowNumber);
            }

        }
    }
}
