using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CardsUtkast1
{
    internal class Cards : IEnumerable<Cards>
    {
        public string[] Suits { get; }
        public string[] Tag { get; }
        public int[] Value { get; set; } //mulighet å endre om eks. blackjack 11-13 = 10 A = 11/1;
        public List<Card> Deck { get; set; }

        public Cards()
        {
           Suits = new[] {"♠", "♥", "♦", "♣"};
           Value = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
           Tag = new[] {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
           Deck = ShuffleDeck(); /*NewDeck(); om det ikke skal shuffles av en eller annen grunn(?)*/
        }

        public List<Card> ShuffleDeck()
        {
            var OrderedDeck = NewDeck();
            
            var shuffledDeck = OrderedDeck.OrderBy(i => Guid.NewGuid()).ToList();
            return shuffledDeck;
        }

        // KAN LEGGES INN METODE HVIS VALGT KORTSPILL SKAL HA ANDRE VERDIER PÅ KORTENE; TYPISK BLACKJACK 11-13 = 10 A=1/11.
        public List<Card> NewDeck()
        {
            var deck = new List<Card>();
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < Value.Length; j++)
                {
                    var compTag = Suits[i] + Tag[j];
                    var comPCard = new Card(compTag, Value[j]);
                    deck.Add(comPCard); 
                }
            }
            return deck;
        }

        public IEnumerator<Cards> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
