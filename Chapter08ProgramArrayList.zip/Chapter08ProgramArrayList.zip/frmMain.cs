using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Chapter08ProgramArrayList.zip
{
    public partial class frmMain : Form
    {
        ArrayList names = new ArrayList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                names.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Input Error");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string str in names)
            {
                listBox1.Items.Add(str);
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
