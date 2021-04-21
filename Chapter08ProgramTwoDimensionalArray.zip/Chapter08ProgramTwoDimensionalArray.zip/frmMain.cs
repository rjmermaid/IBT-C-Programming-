using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramTwoDimensionalArray.zip
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
            int number;
            int i;
            ListViewItem which;

            flag = int.TryParse(textBox1.Text, out number);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only.", "Input Error");
                textBox1.Focus();
                return;
            }
            if(number < 0)
            {
                number *= 1;
            }
            number++;
            int[,] myData = new int[number, 3];
            for (i = 0; i < number; i++)
            {
                myData[i, 0] = i;
                myData[i, 1] = i * i;
                myData[i, 2] = i * i * i;
            }
            for (i = 0; i < number; i++)
            {
                which = new ListViewItem(myData[i, 0].ToString());
                which.SubItems.Add(myData[i, 1].ToString());
                which.SubItems.Add(myData[i, 2].ToString());
                listView1.Items.Add(which);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
