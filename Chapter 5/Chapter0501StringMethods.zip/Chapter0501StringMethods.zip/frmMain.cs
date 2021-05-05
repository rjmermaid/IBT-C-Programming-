using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter0501StringMethods.zip
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            UpdateTimeInfo(); 
        }
        private void UpdateTimeInfo()
        {
            int Days;
            DateTime myTime = new DateTime();
            myTime = DateTime.UtcNow;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);

            txtFull.Text = myTime.ToString("f");
            txtLong.Text = myTime.ToString("D");
            txtShort.Text = myTime.ToString("d");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");
            txtGeneral.Text = myTime.ToString("g");

            Days = newYears.DayOfYear - myTime.DayOfYear;
            txtNewYears.Text = Days.ToString();
        }

        private void UpdateTimeInfo(int year, int month, int day)
        {   
            int Days;
            DateTime myTime = new DateTime(year, month, day);
            myTime = DateTime.UtcNow;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);

            txtFull.Text = myTime.ToString("f");
            txtLong.Text = myTime.ToString("D");
            txtShort.Text = myTime.ToString("d");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");
            txtGeneral.Text = myTime.ToString("g");

            Days = newYears.DayOfYear - myTime.DayOfYear;
            txtNewYears.Text = Days.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo(2008, 6, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
