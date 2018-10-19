using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! What is your name:   ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}!");
            Console.Write("Enter a number between 1 and 100:   ");
            string userNumberEntry = Console.ReadLine();

            bool userNumberValidator = UInt32.TryParse(userNumberEntry, out UInt32 userNumber);

            while (!userNumberValidator)
            {
                Console.WriteLine($"Hey {userName}!!! Please enter a number between 1 and 100: ");
                userNumberEntry = Console.ReadLine();
                userNumberValidator = UInt32.TryParse(userNumberEntry, out userNumber);

                if (userNumber > 0 && userNumber < 100)
                {
                    continue;
                }

                break;
            }

            Console.ReadKey();
            


        }
    }
}
