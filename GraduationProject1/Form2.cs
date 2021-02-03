using GraduationProject1.DesignPatterns.SingletonPattern;
using GraduationProject1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationProject1
{
    public partial class Form2 : Form
    {
        AirportDBEntities db;
        public Form2()
        {
            InitializeComponent();
            db = DBTool.DBInstance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbSirketler.DataSource = db.AirlineCompanies.ToList();
            cmbSirketler.DisplayMember = "CompanyName";
            cmbSirketler.ValueMember = "AirlineID";
            /*Dictionary<int, string> sirketler = new Dictionary<int, string>() { { 277, "Turkish Airlines" }, { 84, "Pegasus Airlines" }, { 33, "OnurAir" }, { 36, " AnadoluJet" } };

            foreach (var item in sirketler) { cmbSirketler.Items.Add(item); }
            grbInfo.Enabled = false;*/




        }

      //  Dictionary<int, string> bilgiler = new Dictionary<int, string>();



        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            /*CurrentlyUsage(checkBox7, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key, 1, 2, "Quantitiy of Planes(Currently in Usage:");*/


        }

        private void CurrentlyUsage(CheckBox chbx, int count, int key1, int key2, string metin)
        {
           /* if (dateTimePicker1.Value.ToShortDateString() == "11.06.2020")
            {
                if (chbx.Checked == true)
                {
                    bilgiler.Add(key1, $"{metin} {count})");
                }
                else
                    bilgiler.Remove(key1);

            }
            else if (dateTimePicker1.Value.ToShortDateString() == "12.06.2020")
            {
                if (chbx.Checked == true)
                {
                    bilgiler.Add(key2, $"{metin} {count - 2})");
                }
                else
                    bilgiler.Remove(key2);
            }*/
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            /*CurrentlyUsage(checkBox6, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key - 3, 2, 3, "Quantity Of Planes (in Maintain):");*/
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            /*CurrentlyUsage(checkBox5, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key - 15, 4, 5, "Quantity of Planes (At Apron):");*/
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           /* CurrentlyUsage(checkBox4, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key - 5, 6, 7, "Quantity of Planes (On Air):");*/
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            /*CurrentlyUsage(checkBox3, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key * 2, 8, 9, "Scheduled Flights(Selected Date):");*/
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //CurrentlyUsage(checkBox2, ((KeyValuePair<int, string>)cmbSirketler.SelectedItem).Key, 10, 11, "Pilot (On Air):");
        }



        private void cmbSirketler_SelectedIndexChanged(object sender, EventArgs e)
        {
           // grbInfo.Enabled = true;

        }

        private void cmbSirketler_Format(object sender, ListControlConvertEventArgs e)
        {
            //string name = ((KeyValuePair<int, string>)e.ListItem).Value;
           // e.Value = name;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DateTime currentDate=  dateTimePicker1.Value.Date;
           
            dataGridView1.DataSource = null;
            int companyID = Convert.ToInt32(cmbSirketler.SelectedValue);
            dataGridView1.DataSource = db.AirportInformations.Where(x => x.AirlineCompanyID == companyID && x.InformationDate == currentDate).ToList();

            if (!checkBox7.Checked) dataGridView1.Columns["QuantityOfPlanesInUsage"].Visible = false;
            if (!checkBox6.Checked) dataGridView1.Columns["QuantityOfPlanesInMaintain"].Visible = false;
            if (!checkBox5.Checked) dataGridView1.Columns["QuantityOfPlanesAtApron"].Visible = false;
            if (!checkBox4.Checked) dataGridView1.Columns["QuantityOfPlanesOnAir"].Visible = false;
            if (!checkBox3.Checked) dataGridView1.Columns["ScheduledFlights"].Visible = false;
            if (!checkBox2.Checked) dataGridView1.Columns["Pilot"].Visible = false;
           
       



         




        }

        private void ListBoxInfo_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = @"C:\Users\Melisa\Desktop\havalimanı detaylı raporları";

            //OpenFileDialog openFileDialog1 = new OpenFileDialog
            //{
            //    InitialDirectory = @"C:\Users\Melisa\Desktop\havalimanı detaylı raporları",
            //    Title = "Browse docx Files",

            //    CheckFileExists = true,
            //    CheckPathExists = true,

            //    DefaultExt = "docx",
            //    // Filter = "txt files (*.txt)|*.txt",
            //    FilterIndex = 2,
            //    RestoreDirectory = true,

            //    ReadOnlyChecked = true,
            //    ShowReadOnly = true
            //};
            //openFileDialog1.ShowDialog();
            //openFileDialog1.OpenFile();
            //using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
            //{
            //    MessageBox.Show(sr.ReadToEnd());
            //}

            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");

        }
    }
}
