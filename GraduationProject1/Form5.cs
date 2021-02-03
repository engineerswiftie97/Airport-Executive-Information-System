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
using System.Windows.Forms;

namespace GraduationProject1
{
    public partial class Form5 : Form
    {
        AirportDBEntities db;
        public Form5()
        {
            InitializeComponent();
            db = DBTool.DBInstance;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmbSelect.DataSource = db.WorkFields.ToList();
            cmbSelect.DisplayMember = "FieldName";
            cmbSelect.ValueMember = "FieldID";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int workfieldID = Convert.ToInt32(cmbSelect.SelectedValue);

            int employeeID = 0;

            if (textBox2.Text.Trim() != "")
            {


                try
                {
                    employeeID = Convert.ToInt32(textBox2.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen numerik bir deger giriniz");
                }
                if (!db.EmployeeInfos.Any(x => x.EmployeeID == employeeID))
                {
                    MessageBox.Show("Aradıgınız elemena bulunamadı");
                    return;
                }
                dataGridView1.DataSource = db.EmployeeInfos.Where(x => x.EmployeeID == employeeID && x.WorkFieldID == workfieldID).ToList();
            }

            else if (textBox1.Text.Trim()!="")
            {

                dataGridView1.DataSource = db.EmployeeInfos.Where(x =>(x.WorkFieldID==workfieldID)&& x.EmployeeName.Contains(textBox1.Text) || x.EmployeeLastname.Contains(textBox1.Text) || x.CardNumber.Contains(textBox1.Text) || x.EmployeeNumber.Contains(textBox1.Text) || x.EmployeeEmail.Contains(textBox1.Text) || x.EmployeePhoneNumber.Contains(textBox1.Text)).ToList();

            }

            else
            {
                dataGridView1.DataSource = db.EmployeeInfos.Where(x=>x.WorkFieldID==workfieldID).ToList();
            }





        }
    }
}
