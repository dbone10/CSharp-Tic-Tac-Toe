using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static int player = 1;
        public static int choice;
        public static int flag = 0;

        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X\nPlayer 2: O");
                Console.WriteLine();
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Turn");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn");
                }
                Console.WriteLine();
                Board.DrawBoard();
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine();
                    Console.WriteLine("Please wait 2 second the board is reloading...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin.CheckWinner();
            } while (flag!=1 && flag!=-1);

            Console.Clear();
            Board.DrawBoard();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    }
}
