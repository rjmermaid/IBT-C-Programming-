using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramTableOfSquares.zip
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
            int i;
            int start;
            int end;
            string buff;
            int nextOddInteger;
            int j;
            int square;
            flag = int.TryParse(textBox1.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                textBox1.Focus();
                return;
            }
            flag = int.TryParse(textBox2.Text, out end);
            if(flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                textBox2.Focus();
                return;
            }

            if(end <= start)
            {
                MessageBox.Show("Start is greater than end", "Input Error");
                textBox1.Focus();
                return;
            }

            /*for( i=start; i<=end; i++)
            {
                buff = string.Format("{0, 5}{1, 20}", i, i * i);
                listBox1.Items.Add(buff);
            }

            for(i = start; i <= end; i++)
            {
                nextOddInteger = 1;
                square = 0;
                for (j = 0; j < 1; j++)
                {
                    square += nextOddInteger;
                    nextOddInteger += 2;
                }
                buff = String.Format("{0, 5}{1, 20}", i, square);
                listBox1.Items.Add(buff);
            }*/

            i = start;
            while (i <= end)
            {
                buff = String.Format("{0, 5}{1, 20}", i, i * i);
                listBox1.Items.Add(buff);
                i++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
    }
}
