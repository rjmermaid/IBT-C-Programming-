using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BlackJack.zip
{
    class clsDeck
    {
        List<clsCard> currentDeck;
        int sizeOfDeck;

        public clsDeck()
        {
            sizeOfDeck = 53;
            currentDeck = new List<clsCard>(sizeOfDeck);
        }

        public List<clsCard> getDeck()
        {
            return currentDeck;
        }

        public void makeDefaultDeck()
        {
            clsCard newCard;
            for (int i = 0; i <= 52; i++)
            {
                if (i < 13)
                {
                    if (i == 0)
                    {
                        newCard = new clsCard(1, 14, "red");
                    }
                    else
                    {
                        newCard = new clsCard(1, i + 1, "red");
                    }
                }
                else if (i < 26)
                {
                    if (i == 13)
                    {
                        newCard = new clsCard(2, 14, "red");
                    }
                    else
                    {
                        newCard = new clsCard(2, i - 12, "red"); 
                    }
                }
                else if (i < 39)
                {
                    if (i==26)
                    {
                        newCard = new clsCard(3, 14, "red");
                    }
                    else
                    {
                        newCard = new clsCard(3, i - 25, "red");
                    }
                }
                else
                {
                    if (i == 39)
                    {
                        newCard = new clsCard(4, 14, "red");
                    }
                    else
                    {
                        newCard = new clsCard(4, i - 39, "red");
                    }
                }

                currentDeck.Add(newCard);
            }
        }

        public void createEmptyDeck(int size)
        {
            currentDeck = new List<clsCard>(size);
        }

        public void printDeck()
        {
            for (int i = 0; i < sizeOfDeck; i++)
            {
                Console.WriteLine("Suit: " + currentDeck[i].getSuitString() + " Value: " + currentDeck[i].getValue());
            }
        }

        public void resetFaceCards()
        {
            for (int i = 0; i < 53; i++)
            {
                if (currentDeck[i].IsFaceCard)
                {
                    currentDeck[i].changeValue(10);
                }
            }
        }

        public void shuffleDeck()
        {
            Random rnd = new Random();
            List<clsCard> tempDeck = new List<clsCard>(sizeOfDeck);
            int rndNum = 0;

            for (int i = 0; i < 53; i++)
            {
                rndNum = rnd.Next(0, sizeOfDeck);
                tempDeck.Add(currentDeck[rndNum]);
                currentDeck.RemoveAt(rndNum);
                sizeOfDeck--;
            }
            for (int j = 0; j < 53; j++)
            {
                currentDeck.Add(tempDeck[j]);
            }
        }
    }
}
