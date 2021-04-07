using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02Program02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDisplayOutput_Click(object sender, EventArgs e)
        {
            String buffer;
            buffer = "Mailing label" + Environment.NewLine + Environment.NewLine;
            buffer = buffer + "  Name: " + txtName.Text + Environment.NewLine;
            buffer = buffer + "  Address: " + txtAddress.Text + Environment.NewLine;
            buffer = buffer + "  City: " + txtCity.Text + "  State: " + txtState.Text + "  Zip: " + txtZip.Text;
            txtDisplayOutput.Text = buffer;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
