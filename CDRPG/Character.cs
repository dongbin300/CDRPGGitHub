using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRPG
{
    public class Character
    {
        List<Card> deck = new List<Card>();
        List<Card> hand = new List<Card>();
        public Character()
        {
        }

        public void ObtainCard(Card card)
        {
            deck.Add(card);
        }

        public void PrintDeck()
        {
            foreach (Card c in deck)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void Draw()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++) {
                int idx = random.Next(deck.Count);
                deck.RemoveAt(idx);
                hand.Add(deck[idx]);
            }
        }
    }
}
