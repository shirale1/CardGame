using CardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top;
        Random rand;

         public Deck()
           
        {
            top = 0;
            int index = 0; 
            cards = new Card[52];
            for(int i = 1; i <= 4; i++)
            {
               
                for (int j = 1; j <= 13; j++)
                { 
                    cards[index] = new Card(j, i);
                    index++;
                }
            }
        }
<<<<<<< HEAD
        private void swap(int i,int j)
        { 
            Card save = cards[i];
            cards[i] = cards[j];
            cards[j] = save;

        }
        public Card Peek() { return null; }

        public void Shuffle() 
        {
            int j;
            Random rand = new Random();
    
        for (int i = 0; i < cards.Length; i++)
        {
            j = rand.Next(i, 52);
                swap(i, j);
        }
=======
        public Card Peek() { return null; }
        public void Shuffle() 
        {

>>>>>>> 7be8420de0a3c3fcff01fa129b70730c334cf089
        }
        public Card Deal() 
        { Card c = cards[top];
            top++;
            return c;
        }
<<<<<<< HEAD
        public void Reset() 
        {
            top = 0;
=======

        public void Reset() 
        {
            
>>>>>>> 7be8420de0a3c3fcff01fa129b70730c334cf089
        }
    }
}

