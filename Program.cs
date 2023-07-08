using System;
using System.Runtime.InteropServices;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();// Run GetAppIno function to get app info

            GreetUser(); // Ask for user's name

            while (true)
            {
                
                // Init correct number
                //int correctNumber = 7;

                // Create a random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, " Please use an actual number");

                        //Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);


                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }
                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            // Set app 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Thihansa Mudalige";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        
        // Ask uer's name and greet
        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            // Tell user it's the wrong number 
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
