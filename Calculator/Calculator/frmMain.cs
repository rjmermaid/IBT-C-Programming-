using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonEqualSign_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox1.Text);
            textBox1.Text += "=";
            textBox1.Text += ;
        }
    }
}
