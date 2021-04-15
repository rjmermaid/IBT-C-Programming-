using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06ProgramSwitch.zip
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
            int myDay;
            string msg = "Today is ";
            flag = int.TryParse(textBox1.Text, out myDay);
            if ( flag == false) 
            {
                MessageBox.Show("Numeric only, 1 thru 7");
                textBox1.Focus();
                return;
            }

            switch (myDay)
            {
                case 1:
                    label1.Text = msg + "Monday";
                    break;
                case 2:
                    label1.Text = msg + "Tuesday";
                    break;
                case 3:
                    label1.Text = msg + "Wednesday";
                    break;
                case 4:
                    label1.Text = msg + "Thursday";
                    break;
                case 5:
                    label1.Text = msg + "Friday";
                    break;
                case 6:
                    label1.Text = msg + "Saturday";
                    break;
                case 7:
                    label1.Text = msg + "Sunday";
                    break;
                default:
                    label1.Text = "You should never get here";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
