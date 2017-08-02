using System;
using System.Collections.Generic;

namespace uno
{
    public class Table
    {
        public Deck drawPile;
        public Deck discardPile;
        public List<Player> currPlayers;
        public bool direction = true;
        public bool gamestatus = false;
    

        public Table(int numPlayers)
        {
            drawPile = new Deck();                    
            currPlayers = new List<Player>();
            
            for(int i = 1; i < numPlayers+1; i++){
                // Console.Clear();   
                Console.Write("Enter the player "+i+" name: ");
                string playerName = Console.ReadLine();
                Player Name = new Player(playerName);
                Console.WriteLine("Here we are testing...");
                currPlayers.Add(Name);                
                }
                foreach(Player player in currPlayers){
                    Console.WriteLine(player.name);
                }


        }


    }
}