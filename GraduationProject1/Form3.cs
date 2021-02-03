using GraduationProject1.DesignPatterns.SingletonPattern;
using GraduationProject1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationProject1
{
    public partial class Form3 : Form
    {
        AirportDBEntities db;
        public Form3()
        {
            InitializeComponent();
            db = DBTool.DBInstance;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbOffice.DataSource = db.Offices.ToList();
            cmbOffice.DisplayMember = "OfficeTitle";
            cmbOffice.ValueMember = "OfficeID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int officeID = Convert.ToInt32(cmbOffice.SelectedValue);
           
            DateTime currentDate = dateTimePicker1.Value.Date;
            dataGridView1.DataSource = db.OfficeInformations.Where(x => x.OfficeID == officeID && x.InformationDate == currentDate).ToList();
            if (!checkBox1.Checked) dataGridView1.Columns["WorkerInfo"].Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }
    }
}
