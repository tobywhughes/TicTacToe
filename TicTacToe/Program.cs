using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] gameBoadSpaceArr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int playersMove;
        static int flag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X /n Player 2: O\n\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player O's Turn");
                }
                else
                {
                    Console.WriteLine("Player X's Turn");
                }
                Console.WriteLine('\n');
                Board();

                playersMove = int.Parse(Console.ReadLine()); 

                if (gameBoadSpaceArr[playersMove] != 'X' && gameBoadSpaceArr[playersMove] != 'O')
              
                {
                    if (player % 2 == 0)
                    {
                        gameBoadSpaceArr[playersMove] = 'O';
                    }
                    else
                    {
                        gameBoadSpaceArr[playersMove] = 'X';
                    }
                    player++;
                }

                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", playersMove, gameBoadSpaceArr[playersMove]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }

                flag = CheckWin();
            } while (flag != 1 && flag != -1);
        }
    
        private static int CheckWin()
        {
            if (gameBoadSpaceArr[1] == gameBoadSpaceArr[2] && gameBoadSpaceArr[2] == gameBoadSpaceArr[3])
            {
                return 1;
            }
               
            else if (gameBoadSpaceArr[4] == gameBoadSpaceArr[5] && gameBoadSpaceArr[5] == gameBoadSpaceArr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (gameBoadSpaceArr[6] == gameBoadSpaceArr[7] && gameBoadSpaceArr[7] == gameBoadSpaceArr[8])
            {
                return 1;
            }
       
            else if (gameBoadSpaceArr[1] == gameBoadSpaceArr[4] && gameBoadSpaceArr[4] == gameBoadSpaceArr[7])
            {
                return 1;
            }
            
            else if (gameBoadSpaceArr[2] == gameBoadSpaceArr[5] && gameBoadSpaceArr[5] == gameBoadSpaceArr[8])
            {
                return 1;
            }
            
            else if (gameBoadSpaceArr[3] == gameBoadSpaceArr[6] && gameBoadSpaceArr[6] == gameBoadSpaceArr[9])
            {
                return 1;
            }
            

            else if (gameBoadSpaceArr[1] == gameBoadSpaceArr[5] && gameBoadSpaceArr[5] == gameBoadSpaceArr[9])
            {
                return 1;
            }
            else if (gameBoadSpaceArr[3] == gameBoadSpaceArr[5] && gameBoadSpaceArr[5] == gameBoadSpaceArr[7])
            {
                return 1;
            }
          
           
            else if (gameBoadSpaceArr[1] != '1' && gameBoadSpaceArr[2] != '2' && gameBoadSpaceArr[3] != '3' && gameBoadSpaceArr[4] != '4' && gameBoadSpaceArr[5] != '5' && gameBoadSpaceArr[6] != '6' && gameBoadSpaceArr[7] != '7' && gameBoadSpaceArr[8] != '8' && gameBoadSpaceArr[9] != '9')
            {
                return -1;
            }
           

            else
            {
                return 0;
            }
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoadSpaceArr[1], gameBoadSpaceArr[2], gameBoadSpaceArr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoadSpaceArr[4], gameBoadSpaceArr[5], gameBoadSpaceArr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoadSpaceArr[7], gameBoadSpaceArr[8], gameBoadSpaceArr[9]);
            Console.WriteLine("     |     |      ");
        }
    }


        
    
}
