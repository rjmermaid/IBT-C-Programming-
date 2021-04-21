using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09ProgramClassDesign.zip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int year;
            int leap;
            clsDates myDate = new clsDates();
            flag = int.TryParse(textBox1.Text, out year);
            if (flag == false)
            {
                MessageBox.Show("Digits characters only in YYYY format.", "Input Error");
                textBox1.Focus();
                return;
            }
            leap = myDate.getLeapYear(year);
            label2.Text = year.ToString() + " is " + ((leap == 1) ? "":"not ") + "a leap year";
            label3.Text = myDate.getEaster(year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
