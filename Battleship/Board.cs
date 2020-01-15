using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        int[,] board = new int[20, 20];
        

        public void BuildBoard()
        {
            
            for (int i = 0; i < board.GetLength(0); i++)
            {
                
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if (j == board.GetLength(1) - 1)
                    {
                        Console.WriteLine(board[i, j]);
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }
                
                }
            }
        }
    }
}
