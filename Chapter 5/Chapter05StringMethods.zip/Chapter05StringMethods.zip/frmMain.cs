using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05StringMethods.zip
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
            int index;
            int start;
            int HowMany;
            string temp;

            lblIndexOf.Text = " ";
            txtLength.Text = txtInput.Text.Length.ToString();
            
            txtToUpper.Text = txtInput.Text.ToUpper();
            txtToLower.Text = txtInput.Text.ToLower();

            index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
            lblIndexOf.Text = "txt.Input.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
            txtLastIndexOf.Text = index.ToString();
            
            flag = int.TryParse(txtStartIndex.Text, out start);
            if (flag == false) 
            {
                MessageBox.Show("Improper nemric input. Re-enter.");
                txtStartIndex.Focus();
                return;
            }
            
            flag = int.TryParse(txtEndIndex.Text, out HowMany);
            if (flag == false) 
            {
                MessageBox.Show("Improper nemric input. Re-enter.");
                txtEndIndex.Focus();
                return;
            }

            lblSubstring.Text = "txt.Input.Text.Substring(" + start.ToString() + ", " +
                HowMany.ToString() + ") = ";
            txtSubstringResult.Text = txtInput.Text.Substring(start, HowMany);

            temp = txtInput.Text;
            index = temp.IndexOf(txtRemove.Text);
            if (index > 0) 
            {
                txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
            }

            temp = txtInput.Text;
            txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);
        }
    }
}
