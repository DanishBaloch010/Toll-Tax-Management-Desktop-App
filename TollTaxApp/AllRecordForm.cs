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
    public partial class AllRecordForm : Form
    {
        public AllRecordForm()
        {
            InitializeComponent();

            AllDriverDataGrid.Columns.Add("A", "AID");
            AllDriverDataGrid.Columns.Add("B", "DriverName");
            AllDriverDataGrid.Columns.Add("C", "Phone Number");
            AllDriverDataGrid.Columns.Add("D", "DriverCNIC");
            AllDriverDataGrid.Columns.Add("E", "Vehicle Category");
            AllDriverDataGrid.Columns.Add("F", "CrossingVehicle");
            AllDriverDataGrid.Columns.Add("G", "FromCity");
            AllDriverDataGrid.Columns.Add("H", "ToCity");
            AllDriverDataGrid.Columns.Add("I", "TravelDate");
            AllDriverDataGrid.Columns.Add("J", "TollTax");
            AllDriverDataGrid.Columns.Add("K", "Passengers");

            AllDriverDataGrid.Columns[0].Width = 50;
            AllDriverDataGrid.Columns[1].Width = 100;
            AllDriverDataGrid.Columns[2].Width = 100;
            AllDriverDataGrid.Columns[3].Width = 110;
            AllDriverDataGrid.Columns[4].Width = 100;
            AllDriverDataGrid.Columns[5].Width = 100;
            AllDriverDataGrid.Columns[6].Width = 110;
            AllDriverDataGrid.Columns[7].Width = 60;
            AllDriverDataGrid.Columns[8].Width = 160;
            AllDriverDataGrid.Columns[9].Width = 55;
            AllDriverDataGrid.Columns[10].Width = 75;
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closepicbox_MouseEnter(object sender, EventArgs e)
        {
            closepicbox.Image = Image.FromFile(@"icons\close.png");
        }

        private void closepicbox_MouseLeave(object sender, EventArgs e)
        {
            closepicbox.Image = Image.FromFile(@"icons\close_black.png");
        }

        private void AllRecordForm_Load(object sender, EventArgs e)
        {
            AllDriverDataGrid.Rows.Clear(); //To avoid Repeatetion in Data.
            int Count = 0;
            string AllDriverDataGridLine = null;
            string[] Arr;
            StreamReader SR = new StreamReader(@"alldriverdata.txt");
            while (SR.EndOfStream != true)
            {
                AllDriverDataGridLine = SR.ReadLine();
                Arr = AllDriverDataGridLine.Split('#');
                AllDriverDataGrid.Rows.Add(Arr[0], Arr[1], Arr[2], Arr[3], Arr[4], Arr[5], Arr[6], Arr[7], Arr[8], Arr[9], Arr[10]);
                Count++;
            }
            SR.Close();
            lblCount.Text = "Total Records: " + Count;
        }


    }
}
