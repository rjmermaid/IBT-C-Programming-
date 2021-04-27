using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10ProgramShuffleDeskClass.zip
{
    public partial class frmMain : Form
    {
        const int CARDPERLINE = 13;

        public frmMain()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            int cardIndex;
            int deckSize;
            int passes;
            string buff;
            string temp;
            clsCardDeck myDeck = new clsCardDeck();

            passes = myDeck.shuffleDeck();
            label1.Text = "It took " + passes.ToString() + " passes to shuffle the deck";
            deckSize = myDeck.DeckSize;

            for (cardIndex = 1; cardIndex < deckSize + 1;)
            {
                for (j = 0; j < CARDPERLINE; j++)
                {
                    temp = myDeck.getOneCard(cardIndex);
                    if (temp.Length == 0)
                    {
                        MessageBox.Show("Error reading back.", "Processing error");
                        return;
                    }
                    buff += temp + " ";
                    cardIndex++;
                }
                listBox1.Items.Add(buff);
            }
            listBox1.Items.Add(" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
