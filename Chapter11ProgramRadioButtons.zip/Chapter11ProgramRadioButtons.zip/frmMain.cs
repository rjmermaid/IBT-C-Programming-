using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11ProgramRadioButtons.zip
{
    public partial class frmMain : Form
    {
        const int MALE = 1;
        const int FEMALE = 2;
        const int MUSHROOMS = 0;
        const int OLIVES = 1;
        const int SAUSAGE = 2;
        const int CHEESE = 3;
        public frmMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int choice;
            int[] toppings = new int[4];
            RadioButton button = (RadioButton)sender;
            if (button.Checked == true)
            {
                choice = int.Parse(button.Text);
            }
            Array.Clear(toppings, 0, toppings.Length);
            if(checkBox1.Checked == true)
            {
                toppings[MUSHROOMS] = 1;
            }
            if(checkBox2.Checked == true)
            {
                toppings[OLIVES] = 1;
            }
            if(checkBox3.Checked == true)
            {
                toppings[SAUSAGE] = 1;
            }
            if(checkBox4.Checked == true)
            {
                toppings[CHEESE] = 1;
            }
            string date = dateTimePicker1.Value.ToShortDateString();
            string time = dateTimePicker2.Value.ToShortTimeString();
            string buff = comboBox1.Text;
            int i = comboBox1.SelectedIndex;
        }
    }
}
