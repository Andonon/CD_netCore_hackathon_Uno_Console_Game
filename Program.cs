using System;

namespace uno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();
            Console.WriteLine("Welcome to Uno for console...");
            Console.Write("\nHow many players? (2-10): ");
            string playerprompt = Console.ReadLine();
            int numPlayers = Int32.Parse(playerprompt);

            Table table1 = new Table(numPlayers);

            

            // Card jon = new Card("jon", "black", 1);
            // Console.WriteLine(jon.val);
            // Deck bob = new Deck();
            // Console.WriteLine(bob.cards.Count);
            // for(int i = 0; i < bob.cards.Count; i++){
            //         Console.WriteLine(bob.cards[i].strVal);
            //                }
            // Deck one = new Deck();
            // Player ricki = new Player("Ricki");
            // Console.WriteLine(one.cards.Count);
            // ricki.draw(one);
            // Console.WriteLine(ricki.hand.Count);
            // ricki.draw(one);
            // ricki.draw(one);
            // ricki.draw(one);
            // Console.WriteLine(ricki.hand.Count);
            // ricki.draw(one, 10);
            // Console.WriteLine(ricki.hand.Count);
            // ricki.draw(one);
            // ricki.draw(one);
            // Console.WriteLine(ricki.hand.Count);
            // ricki.discard(3);
            // Console.WriteLine(ricki.hand.Count);
            
        }
    }
}
