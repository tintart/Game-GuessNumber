using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int WinningNumber = r.Next(0, 20);

            bool winn = false;

            do
            {
                Console.WriteLine("Guess number between 0 and 20: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x > WinningNumber)
                {
                    Console.WriteLine("The number you entered is too high, try something lower: ");
                
                }

                else if (x < WinningNumber)
                {
                    Console.WriteLine("The number you entered is too low, try something higher: ");

                }

                else if (x == WinningNumber)
                {
                    Console.WriteLine("Great! You guessed it! ");
                    winn = true;

                }
                Console.WriteLine();
            } while (winn == false);

            Console.WriteLine("Did you like the game?");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
