using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsUtkast1
{
    internal class Game
    {
        public string Name;
        public int Decks;
        public string[] games = {"BLACKJACK", "POKER", "KRIG"};
        public static List<Card> Deck;
        public string startCards;


        public Game(string name)
        {
            Name = name;
            Decks = getDeckCount(name);
            Deck = getShuffledDeck(Decks);
            //startCards = getStartCards(name);
        }

        private List<Card> getShuffledDeck(int decks)
        {
            
            for (int i = 0; i < decks; i++)
            {
                //var deck = new Cards();
                //var newDeck = deck.Deck; 
            }
            var deck = new Cards().Deck;
            //var newDeck = deck.Deck;


            return deck;
        }

        private int getDeckCount(string name)
        {
            if (name == games[0]) return 6;
            if (name == games[1]) return 1;
            if (name == games[2]) return 1;
            return 0;
        }
    }
}
