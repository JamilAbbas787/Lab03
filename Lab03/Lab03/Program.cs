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
            string anotherOne;

            // James - so the reasons most developers do not use do while loops is because 
            // developers really value readability.  and from first glance, I'm not really sure where 
            // this boolean is going to be used.  However because of your naming convention, it is 
            // clear that this boolean is going to be used to repeat the loop.  so you solved that 
            // problem by naming convention.  
            //
            // However, an alternative to breaking out of this loop is to just use 
            // break;
            // if the user did not enter "y"
            // or use 
            // continue;
            // if the user did enter "y"
            bool repeatLoop;

            do
            {
                Console.Write("Enter a number between 1 and 100:   ");
                string userNumberEntry = Console.ReadLine();
                // James - This is really cool that you are using a unsigned integer to make sure it's
                // not a negative number, good stuff.  just as a tip though, I would use the C# type 
                // instead of the dotnet type.  so you could use 
                //
                // uint.TryParse(...)
                bool userNumberValidator = UInt32.TryParse(userNumberEntry, out UInt32 userNumber);

                // James - is your number going to be less than 0 if it's an unsigned int ;) 
                while (userNumber <= 0 || userNumber > 100)
                {
                    Console.Write("Enter a number between 1 and 100:   ");
                    userNumberEntry = Console.ReadLine();
                    userNumberValidator = UInt32.TryParse(userNumberEntry, out userNumber);
                }
                // James - I like that your if statements are not nested, good job.
                if (userNumber % 2 != 0)
                {
                    // James - good catch ;) 

                    //the instructions are repetive for odd number. Regardless of the odd number, it says to do the same thing
                    //so I used this for 
                    Console.WriteLine($"Hey {userName}, your number {userNumber} and odd.");
                }
                else if (userNumber % 2 == 0 && userNumber <= 25 && userNumber >= 2)
                {
                    Console.WriteLine($"Hey {userName}, your number is even and less than 25.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine($"Hey {userName}, your number is even.");
                }
                else if (userNumber % 2 == 0 && userNumber > 60)
                {   //same result as even and between 26-60
                    Console.WriteLine($"Hey {userName}, your number is even.");

                }
                Console.Write("Would you like to continue (y/n):   ");
                anotherOne = Console.ReadLine();
                repeatLoop = anotherOne.Equals("y", StringComparison.OrdinalIgnoreCase);
            } while (repeatLoop);
            
            Console.WriteLine($"Goodbye {userName}!!!");
            Console.ReadKey();  
                     
        }

   
    }
}
