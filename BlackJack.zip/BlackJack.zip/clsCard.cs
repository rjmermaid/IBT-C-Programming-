using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.zip
{
    class clsCard
    {
        int suit = 0;
        int value = 0;
        string color = "No color";
        string suitString;
        private string faceCard;
        private bool isFaceCard;

        public clsCard()
        {
            suit = 0;
            value = 0;
            color = null;
            faceCard = "";
            isFaceCard = false;
        }

        public clsCard(int s, int v, string c)
        {
            suit = s;
            value = v;
            color = c;
            if (v == 11)
            {
                isFaceCard = true;
                faceCard = "Jack";
            }
            else if (v == 12)
            {
                isFaceCard = true;
                faceCard = "Queen";
            }
            else if (v == 13)
            {
                isFaceCard = true;
                faceCard = "King";
            }
            else if (v == 14)
            {
                isFaceCard = true;
                faceCard = "Ace";
            }
            else
            {
                isFaceCard = false;
                faceCard = v.ToString();
            }
        }

        public bool IsFaceCard
        {
            get
            {
                return isFaceCard;
            }
            set
            {
                isFaceCard = value;
            }
        }

        public string FaceCard
        {
            get
            {
                return faceCard;
            }
            set
            {
                faceCard = value;
            }
        }

        public void changeSuit(int s)
        {
            suit = s;
        }

        public int getSuit()
        {
            return suit;
        }

        public string getSuitString()
        {
            if (suit == 1) 
                suitString = "Heart";
            else if (suit == 2)
                suitString = "Spade";
            else if (suit == 3)
                suitString = "Diamond";
            else
                suitString = "Club";

            return suitString;
        }

        public void changeValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }

        public void changeColor(string c)
        {
            color = c;
        }

        public string getColor()
        {
            return color;
        }
    }
}
