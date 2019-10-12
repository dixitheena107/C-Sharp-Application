using System;
// namespace
namespace GuessNumber
{ // Main class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // No return : void
            // static: we dont have instance. Refer function

            GetAppInfo();
            UserGreeting();

           
            // Set correct number
            //int correctnum = 7;
            while (true)
            {
                // or generate random number
                Random random = new Random();
                // Set correct number

                int correctnum = random.Next(1, 10);
                // init Guess var

                int guessNum = 0;
                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10 ");

                // while guess num is not 
                while (guessNum != correctnum)
                {
                    // Issue: Exception if entered a string or special character
                    // make sure it's a number


                    string userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out guessNum))
                    {
                        // Print error message
                        ErrorMessage(ConsoleColor.Red, "Not a number");
                        //Keep going otherwise break on next line
                        continue;
                    }
                    // Cast to int and put in guess
                    guessNum = Int32.Parse(userInput);

                    //Match guess to correct number
                    if (guessNum != correctnum)
                    {
                        ErrorMessage(ConsoleColor.Red, "Wrong number try again");
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("{0}: Wrong Number, try again", guessNum);
                        //Console.ResetColor();
                    }

                }
                // output success message

                ErrorMessage(ConsoleColor.Yellow, "Correct Number");
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("{0}: is Correct Number", guessNum);
                //Console.ResetColor();

                // Ask: If play again
                Console.WriteLine("play Again (Y/N)");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }


            }
        }

        static void ErrorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void UserGreeting()
        {
            Console.WriteLine("Enter name : ");

            //Get user input in string
            string inputName = Console.ReadLine();

            // Print
            Console.WriteLine("User Name :" + inputName + " lets play game");
        }

        static void GetAppInfo()
        {
            string name = "Dixit"; // green: assigned not used
            int age = 12;
            //Console.WriteLine("Hello World");
            //Console.Write("Heena"); // No next line

            Console.WriteLine(name + " " + age);
            Console.WriteLine("{0} is {1}", name, age); // placeholder

            //Set app vars
            string appName = "Number Guess";
            string appVersion = "1.0";
            string appAuthor = "Heena Dixit";

            // Change text color in console:
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
