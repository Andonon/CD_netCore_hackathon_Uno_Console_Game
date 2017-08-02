using System;

namespace uno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card jon = new Card("jon", "black", 1);
            // Console.WriteLine(jon.val);
            // Deck bob = new Deck().reset();
            // Console.WriteLine(bob.cards.Count);
            Deck one = new Deck();
            Player ricki = new Player("Ricki");
            Console.WriteLine(one.cards.Count);

            ricki.draw(one);
            Console.WriteLine(ricki.hand.Count);
            ricki.draw(one);
            ricki.draw(one);
            ricki.draw(one);
            Console.WriteLine(ricki.hand.Count);
            ricki.draw(one, 10);
            Console.WriteLine(ricki.hand.Count);
            ricki.draw(one);
            ricki.draw(one);
            Console.WriteLine(ricki.hand.Count);
            ricki.discard(3);
            Console.WriteLine(ricki.hand.Count);
            
        }
    }
}
