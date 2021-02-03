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
using MPLATFORMLib;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GraduationProject1
{
    public partial class Form7 : Form
    {
        AirportDBEntities db;
        public Form7()
        {
            InitializeComponent();
            db = DBTool.DBInstance;


        }

        MPlaylistClass myPlaylist = new MPlaylistClass();


        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Carparks.ToList();
            comboBox1.DisplayMember = "ParkCode";
            comboBox1.ValueMember = "CarParkID";

            timer1.Start();
            //Set and enable a preview,bunları her projede yaz
            myPlaylist.PreviewWindowSet("", panel1.Handle.ToInt32());
            myPlaylist.PreviewEnable("", 1, 1);
            myPlaylist.PropsSet("loop", "false");
            //Start mFile object
            myPlaylist.ObjectStart(new object());
            //Fill video formats
            int nCount;
            int nIndex;
            string strFormat;
            M_VID_PROPS vidProps;

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("6");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int parkID = Convert.ToInt32(comboBox1.SelectedValue);

            dataGridView1.DataSource = db.CarparkAndSecuritiesInfoes.Where(x => x.CarparkID == parkID).ToList();

            if (!checkBox1.Checked) dataGridView1.Columns["Availabilty"].Visible = false;
            if (!checkBox2.Checked) dataGridView1.Columns["EntranceSecurityList"].Visible = false;
            if (!checkBox3.Checked) dataGridView1.Columns["FullnessRatio"].Visible = false;
            if (!checkBox4.Checked) dataGridView1.Columns["CurrentWorkerInfo"].Visible = false;
            if (!checkBox5.Checked) dataGridView1.Columns["TotalCost"].Visible = false;
            if (!checkBox6.Checked) dataGridView1.Columns["VipSecurityInfo"].Visible = false;
            if (!checkBox7.Checked) dataGridView1.Columns["CarparkWorkerList"].Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }
        private void updateList()
        {
            listBox1.Items.Clear();
            int nFiles;
            double dblDuration;
            myPlaylist.PlaylistGetCount(out nFiles, out dblDuration);
            for (int i = 0; i < nFiles; i++)
            {
                string strPathOrCommand;
                MItem pItem;
                double dblPos;
                myPlaylist.PlaylistGetByIndex(i, out dblPos, out strPathOrCommand, out pItem);
                strPathOrCommand = strPathOrCommand.Substring(strPathOrCommand.LastIndexOf('\\') + 1);
                listBox1.Items.Add(strPathOrCommand);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileNames.Length != 0)
            {
                foreach (string t in openFileDialog1.FileNames)
                {
                    int nIndex = -1;
                    MItem pFile;
                    myPlaylist.PlaylistAdd(null, t, "", ref nIndex, out pFile);
                }
                updateList(); // this method allows to keep listBox1 in actual state.
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int val1;
            double val2;
            double x;
            double y;
            double z;
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex >= 0)
            {

                string strPathOrCommand;
                MItem pItem;
                double dblPos;
                myPlaylist.PlaylistGetByIndex(listBox1.SelectedIndex, out dblPos, out strPathOrCommand, out pItem);

                pItem.FileInOutGet(out x, out y, out z);

                double _dbFilePos;
                //item ın position unu get ile alıp sonra ona set ediyoruz. böylece kaldıgı yerden devam edıyo
                pItem.FilePosGet(out _dbFilePos);
                pItem.FilePosSet(_dbFilePos, 0);
                myPlaylist.FilePlayStart();

                //myPlaylist.PlaylistPosSet(listBox1.SelectedIndex, 0, 0);

                myPlaylist.PlaylistGetCount(out val1, out val2);
                label6.Text = "Video Time: " + val2.ToString() + "s";

               


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Melisa\Desktop\Simulation");
        }
    }
}
