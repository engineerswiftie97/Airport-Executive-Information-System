using GraduationProject1.DesignPatterns.SingletonPattern;
using GraduationProject1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPLATFORMLib;
using System.Windows.Forms;
using System.Diagnostics;

namespace GraduationProject1
{
    public partial class Form4 : Form
    {
      
        AirportDBEntities db;
   


        public Form4()
        {
            InitializeComponent();
            db = DBTool.DBInstance;
        }
        int terminalID;
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("G1");
            comboBox1.Items.Add("G10");


        }
        MPlaylistClass myPlaylist = new MPlaylistClass();
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.ApronInformations.Where(x => x.TerminalID == terminalID).ToList();

            if (!checkBox1.Checked) dataGridView1.Columns["Availability"].Visible = false;



        }

        private void rdbDomestic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDomestic.Checked)
            {
                terminalID = 1;

            }
        }


        private void rdbVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVIP.Checked)
            {
                terminalID = 3;

            }
        }

        private void rdbInternational_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInternational.Checked)
            {
                terminalID = 2;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }
    }

}

