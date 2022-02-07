using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace CardsUtkast1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cardCount = 5;
            //Console.WriteLine("What game do you wanna play?");
            //foreach (var game in Game.games)
            //{
            //    Console.WriteLine(game);
            //}

            var input = Console.ReadLine().ToUpper();
            //var game1 = new Game(input);
            var game1 = new Game("KRIG");

            //var players = new List<Players>();  // lage egen klasse for players med liste over new players?

            var player1 = new Player("Stigh", cardCount);
            var player2 = new Player("COM", cardCount);

            // Loop med antall spillere; cardCount ut fra games.game[0].cardcount ?

            Console.WriteLine("Playerhand:");

            for (int i = 0; i < cardCount; i++)
            {
                var card = player1.Hand[i];
                Console.Write(card.Tag + " ");
                
            }

            Console.WriteLine(" ");
            Console.WriteLine("Computer hand");
            for (int i = 0; i < cardCount; i++)
            {
                var card = player2.Hand[i];
                Console.Write(card.Tag + " ");

            }
            Console.WriteLine(" ");
            Console.WriteLine("Kort igjen i deck: " + Game.Deck.Count);
            Console.ReadLine();
        }
    }

}
