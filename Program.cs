using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {

        static char[,] playField = { { '1','2','3'},//Row 0
                              { '4','5','6'},//Row 1
                              { '7','8','9' } };//Row 2
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DrawBoard();
                do
                {
                    Console.WriteLine("\n Player {0}: Choose the Field", player);
                    input = Convert.ToInt32(Console.ReadLine());
                } while (!inputCorrect);
            } while (true);






            Console.ReadLine();
        }

        private static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';


            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;

                case 2: playField[0, 1] = playerSign; break;

                case 3: playField[0, 2] = playerSign; break;

                case 4: playField[1, 0] = playerSign; break;

                case 5: playField[1, 1] = playerSign; break;

                case 6: playField[1, 2] = playerSign; break;

                case 7: playField[2, 0] = playerSign; break;

                case 8: playField[2, 1] = playerSign; break;

                case 9: playField[2, 2] = playerSign; break;

            }






        }

        private static void DrawBoard()
        {
            //This is a method to draw 3*3 Board
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
        }
    }
}



