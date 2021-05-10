using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.zip
{
    public partial class frmMain : Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public frmMain()
        {
            InitializeComponent();
        }

        static void Main()
        {
            
        }
        public static void PlayBlackJack()
        {
            clsDeck gameDeck = new clsDeck();
            List<clsCard> playingDeck;
            gameDeck.makeDefaultDeck();
            gameDeck.resetFaceCards();

            int minNumCards = 20;
            bool winner = false;
            int dealerTotal = 0;
            int playerTotal = 0;

            gameDeck.shuffleDeck();

            playingDeck = gameDeck.getDeck();

            List<clsCard> p1Hand = new List<clsCard>();
            List<clsCard> DealerHand = new List<clsCard>();

            while (playingDeck.Count > minNumCards && !winner)
            {
                DealerHand.Add(playingDeck.ElementAt(0));
                p1Hand.Add(playingDeck.ElementAt(1));
                DealerHand.Add(playingDeck.ElementAt(2));
                p1Hand.Add(playingDeck.ElementAt(3));

                dealerTotal = DealerHand.ElementAt(0).getValue() + DealerHand.ElementAt(1).getValue();
                playerTotal = p1Hand.ElementAt(0).getValue() + p1Hand.ElementAt(1).getValue();

                for (int i = 0; i < 4; i++)
                {
                    playingDeck.RemoveAt(i);
                }

                if (dealerTotal > playerTotal && dealerTotal < 22)
                {

                }
                else if (playerTotal > 21)
                {

                }
                else if (dealerTotal > 21)
                {

                }
                else if (playerTotal > dealerTotal)
                {

                }

            }
        }
        

    }
}
