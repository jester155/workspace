using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    class CoinFlip
    {
        private static int bet; //Holds the bet information
        static Random r = new Random(Environment.TickCount); // Random generator object

        public static void start() //Beginning of the game
        {
            Console.WriteLine("Flip a coin. Best of three and you win.");
            bet = Banking.Money.placeBet(); //Gets the users bet and holds tehe information in bet
            flip();
        }

        private static void flip() //Perfors the action of 'flipping' the coin
        {
            int z = call(); //holds the user input of heads or tails
            int head = 0, tail = 0, coin;

            for (int i = 1; i <= 3; i++) //Perfors the coin flip 3 times
            {
                coin = r.Next(0, 2); //Random generator can only choose between 0 or 1

                if(coin == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tails ");
                    Console.ResetColor();
                    tail++;
                }
                else if (coin == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Heads ");
                    Console.ResetColor();
                    head++;
                }
            }
            getResult(tail , head , z);
        }

        private static int call() //Gets the user to call heads or tails
        {
            int x = 0;

            Console.WriteLine("Call heads or tails");
                String h = Console.ReadLine();

                if (h.Equals("heads"))
                {
                    Console.WriteLine("You have chosen {0}!" , h);
                        x = 1;
                }
                else if (h.Equals("tails"))
                {
                    Console.WriteLine("You have chosen {0}!", h);
                    x = 2;
                }
                else
                {
                    Console.WriteLine("{0} is not a valid entry" , h);
                    call();
                }
            return x;
        }

        private static void getResult(int t, int h, int f) //Finds the result of the game, wether the user won or lost
        {
            bool win;
            String w = "You Win!";
            String l = "You Lose...";

                if (t > 1 && f == 2)
                {
                    Console.WriteLine(w);
                    win = true;
                }
                else if (h >= 2 && f == 1)
                {
                    Console.WriteLine(w);
                    win = true;
                }
                else
                {
                    Console.WriteLine(l);
                    win = false;
                }
                Banking.Money.totalOut(bet, win);
                Console.WriteLine("You now have ${0}", Banking.Money.getMoney());
        }

    }
}