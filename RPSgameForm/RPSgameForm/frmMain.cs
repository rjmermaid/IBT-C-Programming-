using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSgameForm
{
    public partial class frmMain : Form
    {
        int winscore = 0;
        int tiescore = 0;
        int losescore = 0;
        public frmMain()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


         
            string[] choices = new string[3] { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);



            label1.Text = ("Computer's choice is - " + choices[n]);

            if (choices[n] == "Scissors")
            {
                pictureBox1.Image = imageList1.Images[0];
                label5.Text = "You win :)";
                winscore++;
                textBox1.Text = winscore.ToString();

            }
            else if (choices[n] == "Paper")
            {
                pictureBox1.Image = imageList1.Images[1];
                label5.Text = "You loose :(";
                losescore++;
                textBox2.Text = losescore.ToString();
            }
            else
            {
                pictureBox1.Image = imageList1.Images[2];
                label5.Text = "It's a tie :|";
                tiescore++;
                textBox3.Text = tiescore.ToString();
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            string[] choices = new string[3] { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);



            label1.Text = ("Computer's choice is - " + choices[n]);

            if (choices[n] == "Rock")
            {
                pictureBox1.Image = imageList1.Images[2];
                label5.Text = "You win :)";
                winscore++;
                textBox1.Text = winscore.ToString();

            }
            else if (choices[n] == "Scissors")
            {
                pictureBox1.Image = imageList1.Images[0];
                label5.Text = "You loose :(";
                losescore++;
                textBox2.Text = losescore.ToString();
            }
            else
            {
                pictureBox1.Image = imageList1.Images[1];
                label5.Text = "It's a tie :|";
                tiescore++;
                textBox3.Text = tiescore.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string[] choices = new string[3] { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);



            label1.Text = ("Computer's choice is - " + choices[n]);
           

            if (choices[n] == "Paper")
            {
                pictureBox1.Image = imageList1.Images[1];
                label5.Text = "You win :)";
                winscore++;
                textBox1.Text = winscore.ToString();

            }
            else if (choices[n] == "Rock")
            {
                pictureBox1.Image = imageList1.Images[2];
                label5.Text = "You loose :(";
                losescore++;
                textBox2.Text = losescore.ToString();
            }
            else
            {
                pictureBox1.Image = imageList1.Images[0];
                label5.Text = "It's a tie :|";
                tiescore++;
                textBox3.Text = tiescore.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

