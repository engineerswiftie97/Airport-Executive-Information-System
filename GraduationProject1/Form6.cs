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
    public partial class Form6 : Form
    {
        AirportDBEntities db;
        public Form6()
        {
            InitializeComponent();
            db = DBTool.DBInstance;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.TechnicUnits.ToList();
            comboBox1.DisplayMember = "TechnicUnitName";
            comboBox1.ValueMember = "UnitID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int technicID = Convert.ToInt32(comboBox1.SelectedValue);
            dataGridView1.DataSource = db.TechnicUnitInfos.Where(x => x.TechnicUnitID == technicID).ToList();
            if (!checkBox1.Checked) dataGridView1.Columns["AircraftCodes"].Visible = false;
            if (!checkBox2.Checked) dataGridView1.Columns["YearsOfAircraft"].Visible = false;
            if (!checkBox3.Checked) dataGridView1.Columns["FullnessRatio"].Visible = false;
            
            if (!checkBox5.Checked) dataGridView1.Columns["Cost"].Visible = false;
            if (!checkBox6.Checked) dataGridView1.Columns["PreviousMaintainAircraft"].Visible = false;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }
    }
}
