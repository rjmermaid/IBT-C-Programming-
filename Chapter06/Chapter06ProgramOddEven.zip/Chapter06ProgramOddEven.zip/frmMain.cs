using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06ProgramOddEven.zip
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
            int val;
            string output = "Number is even";
            flag = int.TryParse(textBox1.Text, out val);
            if (flag == false) 
            {
                MessageBox.Show("Not a number. Re-enter.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            /*if ( val%2 == 1) 
            {
                output = "Number is odd";
            }
            else
            {
                output = "Number is even";
            }*/
            //output = (val % 2 == 0) ? "Number is even" : "Number is odd";
            //label2.Text = output;
            int day = val;
            if(day == 1)
            {
                day++;
                label1.Text = "Monday";
            }
            else 
                if (day == 2)
                {
                    day += 2;
                    label1.Text = "Tuesday";
                }
                else 
                    if ( day == 3)
                    {
                        day += 3;
                        label1.Text = "Wednesday";
                    }
                    else 
                        if ( day == 4)
                        {
                            day += 4;
                            label1.Text = "Thursday";
                        }
                        else 
                            if ( day == 5)
                            {
                                day += 5;
                                label1.Text = "Friday";
                            }
                            else 
                                if (day == 6) 
                                {
                                    day+=6;
                                    label1.Text = "Saturday";
                                }
                                else 
                                    if (day == 7)
                                    {
                                        day+=7;
                                        label1.Text = "Sunday";
                                    }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
