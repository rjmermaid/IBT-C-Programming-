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
            decimal 3operand1;
            decimal operand2;
            decimal answer;
            flag = decimal.TryParse(txtOperand1.Text, out 3operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            answer = 3operand1 / operand2;
            txtResult.Text = 3operand1.ToString + " divided by " + operand2.ToString() + " equals " + answer.ToString();
            txtResult.Visible = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
