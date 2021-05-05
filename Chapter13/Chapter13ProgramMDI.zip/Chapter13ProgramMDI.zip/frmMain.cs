using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter13ProgramMDI.zip
{
    public partial class frmMain : Form
    {
        string selectFile;
        public frmMain()
        {
            InitializeComponent();
        }
        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();

            fileOpen.Title = "Select file to open";
            fileOpen.Filter = "(*.bin)|*.bin|(*.txt)|*.txt|All files (*.*)|*.*";
            if(fileOpen.ShowDialog() == DialogResult.OK)
            {
                selectFile = fileOpen.FileName;
            }
        }
    }
}
