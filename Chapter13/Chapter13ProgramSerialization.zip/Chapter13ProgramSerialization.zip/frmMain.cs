using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter13ProgramSerialization.zip
{
    public partial class frmMain : Form
    {
        clsSerial myFriend = new clsSerial();
        public frmMain()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            clsSerial newFriend = new clsSerial();
            newFriend = newFriend.DeserializeFriend();
            lstOutput.Items.Clear();
            lstOutput.Items.Add(newFriend.Name);
            lstOutput.Items.Add(newFriend.Email);
            lstOutput.Items.Add(newFriend.Status.ToString());
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            int flag;

            MoveTextToClass(myFriend);

            flag = myFriend.SerializeFriend(myFriend);
            if (flag == 1)
            {
                MessageBox.Show("Data serializes successfully", "Data Write");
            }
            else
            {
                MessageBox.Show("Serialization failure", "Data Error");
            }
        }

        private void MoveTextToClass(clsSerial obj)
        {
            bool flag;
            int val;

            obj.Name = txtName.Text;
            obj.Email = txtEmail.Text;
            flag = int.TryParse(txtStatus.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Must be 1 or 0", "Input Error");
                txtStatus.Focus();
                return;
            }
            obj.Status = val;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }   
    }
}
