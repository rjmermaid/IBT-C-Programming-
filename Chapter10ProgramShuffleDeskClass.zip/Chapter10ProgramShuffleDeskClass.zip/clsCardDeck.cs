using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10ProgramShuffleDeskClass.zip
{
    class clsCardDeck
    {
        private const int DECKSIZE = 52;
        private static string[] pips = 
            {"","AS","2S","3S","4S","5S","6s","7S","8S","9S","TS","JS","QS","KS",
            "AH","2H","3H","4H","5H","6H","7H","8H","9H","TH","JH","QH","KH",
            "AD","2D","3D","4D","5D","6D","7D","8D","9D","TD","JD","QD","KD",
            "AC","2C","3C","4C","5C","6C","7C","8C","9C","TC","JC","QC","KC"};

        private int nextCard;

        private int[] deck = new int[DECKSIZE + 1];
        private int passCount;
        public  clsCardDeck() 
        {
            nextCard = 1;
        }

        public int DeckSize
        {
            get
            {
                return DECKSIZE;
            }
        }

        public int NextCard
        {
            get
            {
                return nextCard;
            }
            set
            {
                if (value > 0 && value <= deck.Length)
                {
                    nextCard = value;
                }
            }
        }

        public int PassCount
        {
            get
            {
                return passCount;
            }
        }

        public int ShuffleDeck()
        {
            int index;
            int val;
            Random rnd = new Random();

            passCount = 0;
            index = 1;
            Array.Clear(deck, 0, deck.Length);

            while(index < deck.Length)
            {
                val = rnd.Next(DECKSIZE) + 1;
                if(deck[val] == 0)
                {
                    deck[val] = index;
                    index++;
                }
                passCount++;
            }
            nextCard = 1;
            return passCount;
        }
        public string getCardPip(int index) 
        {
            if (index > 0 && index <= deck.Length)
            {
                return pips[index];
            }
            else
            {
                return "";
            }
        }
        public string getOneCard(int index) 
        { 
            if(index > 0 && index <= deck.Length && nextCard <= deck.Length)
            {
                NextCard++;
                return pips[deck[index]];
            }
            else
            {
                return "";
            }
        }


    }
}
