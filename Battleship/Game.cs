using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        public Player player1;
        public Player player2;
        public void StartGame()
        {
            Console.WriteLine("Welcome to Battleship!!!");
            Console.ReadLine();
            Console.WriteLine("Start Game Press Enter");
            Console.ReadLine();
            player1.SetName();
            player2.SetName();
            
        }
        
    }
}
    
