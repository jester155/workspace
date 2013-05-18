using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGames
{
    class NumberGuess
    {
        private static int bet; //Holds the bet information
        static Random r = new Random(Environment.TickCount); // Random generator object

        public static void start()
        {
            Console.WriteLine("You will guess a number 1-5 if the number is correct you win");
            bet = Banking.Money.placeBet();
            act();
        }

        private static int compChoice() //Randomly generates the computers choice
        {
            int  comp = r.Next(0, 5) + 1;
            return comp;
        }

        private static int askUser() //Asks the user for their input
        {
            Console.WriteLine("What number do you choose?");
            string u = Console.ReadLine();
            int user = Parse.tryParse(u);

            if (user >= 1 && user <= 5)
            {
                return user;
            }
            else
            {
                Console.WriteLine("{0} is not a vailid option" , user);
                askUser();
                return user;
            }
        }

        private static void act() //Performs aprpriate actions with the computer data and user input
        {
            int c = compChoice();
            int u = askUser();
            getResult(c, u);
        }

        private static void getResult(int c , int u) //Finds the result of the game wether the user won or lost
        {
            bool win;

            Console.WriteLine("The number was {0}, you guessed {1}", c, u);
            if (c == u)
            {
                Console.WriteLine("Wow, You Won!");
                win = true;
            }
            else
            {
                Console.WriteLine("You lost");
                win = false;
            }
            Banking.Money.riskTotalOut(bet, win);
            Console.WriteLine("You now have ${0}", Banking.Money.getMoney());
        }
    }
}
