using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        string userName;

        public void SetName()
        {
            Console.WriteLine("Please type your name in!\n");
            userName = Console.ReadLine();
            Console.WriteLine("\nWelcome " + userName + "\n");
        }
    }
}
