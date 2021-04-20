using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramDoWhileRandaomNumbers.zip
{
    public partial class frmMain : Form
    {
        const int MAXITERATIONS = 200000;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag;
            int cnt;
            int max;
            int last;
            int current;
            Random randomNumber = new Random();

            flag = int.TryParse(textBox1.Text, out max);
            if(flag == false)
            {
                MessageBox.Show("Digit characters only.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Focus();
                return;
            }

            cnt = 0;
            last = (int)randomNumber.Next(max);
            do
            {
                current = randomNumber.Next(max);
                if (last == current)
                {
                    break;
                }
                last = current;
                cnt++;
            } while (cnt < MAXITERATIONS);
            if(cnt < MAXITERATIONS)
            {
                label2.Text = "It look" + cnt.ToString() + "passes to match";
            }
            else
            {
                label2.Text = "No back-to-back match";
            }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
