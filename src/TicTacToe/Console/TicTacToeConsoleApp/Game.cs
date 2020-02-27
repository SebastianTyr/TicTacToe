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

        private void GetBoard()
        {
            Console.WriteLine("Wiatj w klasycznym kółko i krzyżyk, najwspanialszej grze na świecie - miłej zabawy :)");
            Console.WriteLine();
            Console.WriteLine($"{m.Board[0]} | {m.Board[1]} | {m.Board[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{m.Board[3]} | {m.Board[4]} | {m.Board[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{m.Board[6]} | {m.Board[7]} | {m.Board[8]}");
            Console.WriteLine();
        }

        private void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("Remis!");
            Console.WriteLine();
            Environment.Exit(1);
        }

        public void Run()
        {
            GetBoard();

            int move = 0;
            char figureMove = ' ';
            int tmp;

            m.Board[0] = ' ';
            m.Board[1] = ' ';
            m.Board[2] = ' ';
            m.Board[3] = ' ';
            m.Board[4] = ' ';
            m.Board[5] = ' ';
            m.Board[6] = ' ';
            m.Board[7] = ' ';
            m.Board[8] = ' ';

            while (!m.IsWin)
            {
                if(move == 9)
                {
                    Draw();
                }
                if(m.PlayerOne == true)
                {
                    figureMove = 'X';
                }
                else
                {
                    figureMove = 'Y';
                }
                Console.Clear();
                GetBoard();
                Console.WriteLine();
                Console.WriteLine($"Podaj numer komórki {figureMove} (1-9)");

                tmp = int.Parse(Console.ReadLine());

                switch(tmp)
                {
                    case 1:
                        m.Board[0] = figureMove;
                        move++;
                        break;
                    case 2:
                        m.Board[1] = figureMove;
                        move++;
                        break;
                    case 3:
                        m.Board[2] = figureMove;
                        move++;
                        break;
                    case 4:
                        m.Board[3] = figureMove;
                        move++;
                        break;
                    case 5:
                        m.Board[4] = figureMove;
                        move++;
                        break;
                    case 6:
                        m.Board[5] = figureMove;
                        move++;
                        break;
                    case 7:
                        m.Board[6] = figureMove;
                        move++;
                        break;
                    case 8:
                        m.Board[7] = figureMove;
                        move++;
                        break;
                    case 9:
                        m.Board[8] = figureMove;
                        move++;
                        break;
                    default:
                        Console.WriteLine("Nie psuj mnie i spóbuj ponownie :(");
                        break;
                }
                m.PlayerOne = !m.PlayerOne;
                m.CheckWinner();
            }

            Console.Clear();
            GetBoard();
            Console.WriteLine($"Wygrał: {m.WinPlayer}!");
        }
    }
}
