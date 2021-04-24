using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public frmMain()
        {
            InitializeComponent();
            string[] a = { "Miles", "Kilometres", "Pounds", "Kilograms" };
            string[] b = { "Kilometres", "Miles", "Kilograms", "Pounds" };
            comboBox1.DataSource = a;
            comboBox2.DataSource = b;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            label1.Text = result + " " + operation;
            isOperationPerformed = true;
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void buttonEqualSign_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
            }
            else if (operation == "-")
            {
                textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
            }
            else if (operation == "*")
            {
                textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
            }
            else if (operation == "/") 
            { 
                textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
            }
            result = double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void buttonErase_Click_1(object sender, EventArgs e)
        {
            string erased_text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            textBox1.Text = erased_text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double start, result;
            start = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            if (comboBox1.Text == "Miles" && comboBox2.Text == "Kilometres")
            {
                result = start * 1.60934;
                label5.Text = result.ToString();
            }
            else if (comboBox2.Text == "Miles" && comboBox1.Text == "Kilometres")
            {
                result = start / 1.60934;
                label5.Text = result.ToString();
            }
            else if (comboBox1.Text == "Pounds" && comboBox2.Text == "Kilograms")
            {
                result = start * 0.453592;
                label5.Text = result.ToString();
            }
            else if (comboBox2.Text == "Pounds" && comboBox1.Text == "Kilograms")
            {
                result = start / 0.453592;
                label5.Text = result.ToString();
            }
            else if (comboBox2.Text == comboBox1.Text)
            {
                label5.Text = start.ToString();
            }
            else
            {
                label5.Text = "Something is wrong. Change it and then try again";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = true;
        }
    }
}
