using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter15ProgramLINQTest.zip
{
    public partial class frmMain : Form
    {
        private const int MAXNUM = 100;
        static List<int> numbers = new List<int>();


        public frmMain()
        {
            InitializeComponent();
            GenerateRandomValues();
        }

        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void GenerateRandomValues()
        {
            int temp;
            DateTime current = DateTime.UtcNow;
            Random rnd = new Random((int)current.Ticks);

            for (int i = 0; i < MAXNUM; i++)
            {
                temp = rnd.Next(MAXNUM);
                numbers.Add(temp);
                lstFull.Items.Add(temp.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int hi;
            int lo;

            lstOutput.Items.Clear();
            SetTheLimits(out lo, out hi);
            DoLINQQuery(lo, hi);
        }

        private void DoLINQQuery(int lo, int hi)
        {
            var query = from p in numbers
                        where p > lo && p < hi
                        select p;

            foreach (var val in query)
            {
                lstOutput.Items.Add(val.ToString());
            }
        }

        private void SetTheLimits(out int lo, out int hi)
        {
            bool flag = int.TryParse(txtLow.Text, out lo);
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 0 to 100", "Input Error");
                txtLow.Focus();
            }
            flag = int.TryParse(txtHi.Text, out hi);
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 0 to 100", "Input Error");
                txtHi.Focus();
            }
        }
    }
}
