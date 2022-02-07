using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsUtkast1
{
    internal class Player
    {
        private string Name;
        public List<Card> Hand;



        public Player(string name, int cards)
        {
            Name = name;
            Hand = drawCards(cards);
        }

        private List<Card> drawCards(int cards)
        {
            var hand = new List<Card>();
            for (int i = 0; i < cards; i++)
            {
                var drawed = Game.Deck[i];
                hand.Add((drawed));
                Game.Deck.Remove(drawed);
            }

            return hand;
        }
    }
}
