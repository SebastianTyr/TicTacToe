using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Libs;

namespace TicTacToeConsoleApp
{
    public class Game
    {
        Model m = new Model();

        private void DrawBoard()
        {
            Console.WriteLine();
            Console.WriteLine($"{m.Board[0]} | {m.Board[1]} | {m.Board[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{m.Board[5]} | {m.Board[4]} | {m.Board[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{m.Board[6]} | {m.Board[7]} | {m.Board[8]}");
            Console.WriteLine();
        }

        public void Run()
        {
            DrawBoard();
        }
    }
}
