using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter13ErrrorLog.zip
{
    public partial class frmMain : Form
    {
        string err;
        public frmMain()
        {
            InitializeComponent();
            rbDivideBy0.Checked = true;
        }

        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDivideBy0.Checked == true)
                {
                    throw new System.DivideByZeroException();
                }
                else
                {
                    if(rbFileNotFound.Checked == true)
                    {
                        throw new System.IO.FileNotFoundException();
                    }
                    else
                    {
                        throw new System.OverflowException();
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("DivideByZeroException thrown.", "Exception Error");
                err = "DivideByZeroException: " + ex.StackTrace;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("FileNotFoundException thrown.", "Exception Error");
                err = "FileNotFoundException: " + ex.StackTrace;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("OverflowException thrown.", "Exception Error");
                err = "OverflowException: " + ex.StackTrace;
            }
            finally
            {
                clsErrorLog myErrLog = new clsErrorLog(err);
                myErrLog.PathName = Application.StartupPath;

                myErrLog.WriteErrorLog();
                txtErrorMsgs.Text = myErrLog.ReadErrorLog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
