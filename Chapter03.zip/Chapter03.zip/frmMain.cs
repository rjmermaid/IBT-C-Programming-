using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03.zip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int operand1;
            int operand2;
            int answer;
            flag = int.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            flag = int.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            answer = operand1 / operand2;
            txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() + " equals " + answer.ToString();
            txtResult.Visible = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
