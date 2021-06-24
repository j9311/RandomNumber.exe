using System;

//Namespace 
namespace CApp1
{
    //Main Class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {

            GetAppInfo();

            Greeting();
           

            //Set Correct Number initial
            //int correctNumber = 7;

            while (true)
            {

                //create random integer for guessing
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //initial guess variable
                int guess = 0;


                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                while (guess != correctNumber)
                {
                    string inputGuess = Console.ReadLine();

                    //num validate
                    if (!int.TryParse(inputGuess, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkMagenta, "Not an integer, try using a number instead");
                      

                        continue;

                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(inputGuess);

                    //match guess to correctNumber
                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.DarkRed, "Not the correct number, try again");
                        
                    }

                }

                if (guess == correctNumber)
                {

                    PrintColorMessage(ConsoleColor.Green, "That's the correct number, go play the lottery!");

                    //wanna play again?
                    Console.WriteLine("Play again? [Y or n]");

                    //get answer
                    string answer = Console.ReadLine();

                    if (answer == "Y")
                    {
                        continue;
                    } else if (answer == "n")
                    {
                        return;
                    } else
                    {
                        return;
                    }
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "James Post";

            // Change color of console display text
            Console.ForegroundColor = ConsoleColor.Cyan;


            // Display app info
            Console.WriteLine("{0}; Version {1} by {2}", appName, appVersion, appAuthor);

            //reset color scheme for text display
            Console.ResetColor();
        }

        static void Greeting()
        {
            //ask user name
            Console.WriteLine("What's your name?");

            //User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's guess a number shall we?", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
