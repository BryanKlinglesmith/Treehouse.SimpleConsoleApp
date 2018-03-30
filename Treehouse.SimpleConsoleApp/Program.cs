using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;

            while (true)
            {
                //prompt the user for minutes excecised
                Console.Write("Enter how many minutes you excercised or type \"quit\" to exit: ");

                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
               
                try
                {
                    var minutes = double.Parse(entry); //"double" is how to use numbers with decimal points
                                                            //"int" is used for whole numbers only. decimals will cause a compile error.
                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am i right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Are you training to be a ninja warrior or something?");
                    }
                    else
                    {
                        Console.WriteLine("Now you are just showing off!");
                    }

                    //add minutes excercised to total
                    runningTotal += minutes;

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
                    
                //display total minutes excercised to the screen
                Console.WriteLine("you've excercised for " + runningTotal + " minutes");

                //repeat until the user quits
            }

            Console.WriteLine("Goodbye");
        }
    }
}
