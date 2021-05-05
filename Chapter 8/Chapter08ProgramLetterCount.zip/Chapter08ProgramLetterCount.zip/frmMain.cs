using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramLetterCount.zip
{
    public partial class frmMain : Form
    {
        private const int MAXLETTERS = 26;
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;
            length = textBox1.Text.Length;
            if (length == 0)
            {
                MessageBox.Show("You need to enter some text.", "Missing Input");
                textBox1.Focus();
                return;
            }
            input = textBox1.Text;
            input = input.ToUpper();

            for(i = 0; i < input.Length; i++)
            {
                oneLetter = input[i];
                index = oneLetter - LETTERA;
                if( index < 0 || index > MAXCHARS)
                {
                    continue;
                }
                count[index]++;
            }
            /*for(i = 0; i < MAXLETTERS; i++)
            {
                buff = String.Format("{0, 4} {1,20}[{2}]", (char)(i + LETTERA),
                    " ", count[i]);
                listBox1.Items.Add(buff);
            }*/
            ListViewItem which;
            for(i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add(count[i].ToString());
                listView1.Items.Add(which);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
