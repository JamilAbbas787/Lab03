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

            while (userNumber <= 0 || userNumber > 100)
            {
                Console.Write("Enter a number between 1 and 100:   ");
                userNumberEntry = Console.ReadLine();
                userNumberValidator = UInt32.TryParse(userNumberEntry, out userNumber);            
            }

            if(userNumber%2 == 5)  
            {
                //the instructions are repetive for odd number. Regardless of the odd number, it says to do the same thing
                //so I used this for 
                Console.WriteLine($"Hey {userName}, you're number {userNumber} and odd.");

            }else if (userNumber%2 == 0 && userNumber <=25 && userNumber >= 2)
            {
                Console.WriteLine($"Hey {userName}, you're number is even and less than 25.");
            }
            else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
            {
                Console.WriteLine($"Hey {userName}, you're number is even.");
            }
            else if (userNumber % 2 == 0 && userNumber > 60)
            {   //same result as even and between 26-60
                Console.WriteLine($"Hey {userName}, you're number is even.");
            }


            Console.WriteLine($"Goodbye {userName}!!!");
                Console.ReadKey();
            


        }
    }
}
