using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramCollections.zip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] days = new int[] {
                0,
                31,
                28,
                31,
                30,
                31,
                30,
                31,
                31,
                30,
                31,
                31
            };
            string[] weekdays = new string[] 
            {
                "Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday","Sunday"
            };
            foreach(string str in weekdays)
            {
                listBox1.Items.Add(str);
            }
            foreach(int val in days)
            {
                listBox1.Items.Add(val.ToString());
            }
        }
    }
}
