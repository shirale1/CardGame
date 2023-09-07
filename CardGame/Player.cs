using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Player
    {
        private string name;
        private Card[] hand;

        public void Setname(string name)
        {
            this.name = name;
        }
        public void Sethand(Card[] hand)
        {
            
            this.hand = hand;
        }
        public string Getname()
        {
            return name;
        }
        public Card[] Gethand()
        {
            return hand;
        }
        public Player(string name)
        {
            this.name = name;
            hand = new Card[5];
        }
        public void TakeCard(Card c)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                if (hand[i] == null)
                {
                    hand[i] = c;
                }
            }
        }
        public Card Put(int i)
        {
            Card c = hand[i];
            hand[i] = null;
            return c;
        }

    }
}
