using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        private static void menu() //The menu system the is the main controller of the program
        {
            string choice;

            do
            {
                Console.WriteLine("you have ${0}", Banking.Money.getMoney());
                Console.WriteLine("Which game would you like you like to play?");
                Console.WriteLine("1: Coin Flip");
                Console.WriteLine("2: Guess a Number");
                string g = Console.ReadLine();
                int game = Parse.tryParse(g);

                if (game == 1)
                {
                    CoinFlip.start();
                }
                else if (game == 2)
                {
                    NumberGuess.start();
                }
                else
                {
                    menu();
                }
                
                bool c = Banking.Money.canContinue();

                if (c == true)
                {
                    Console.WriteLine("Do you want to play again?");
                    choice = Console.ReadLine();
                    choice.Trim();
                }
                else
                {
                    choice = "no";
                }

            } while (choice != "no");
            newGame();
        }

        private static void exit()
        {
            Environment.Exit(0);
        }

        private static void newGame()
        {
            Console.WriteLine("Would you like to start a new game?");
            string d = Console.ReadLine();

            if (d.Equals("yes"))
            {
                Banking.Money.resetMoney();
                menu();
            }
            else if (d.Equals("no"))
                exit();
            else
            {
                Console.WriteLine("{0} is an invalid option", d);
                newGame();
            }
        }
    }
}