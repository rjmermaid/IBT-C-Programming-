using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEPTIONEX
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int exp1 = int.Parse(txtExpression1.Text);
            int exp2 = int.Parse(txtExpression2.Text);
            int result;

            MessageBox.Show("exp1 = " + exp1.ToString());

            try
            {
                result = exp1 / exp2;
                MessageBox.Show("Never get here");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Expression 1 is zero. Please re-enter.", "Exception Thrown");
                txtExpression1.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Thrown");
            }
            finally
            {
                MessageBox.Show("In finally");
            }

        }
    }
}
