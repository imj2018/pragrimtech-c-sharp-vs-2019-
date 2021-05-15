using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do 
            {
                Console.WriteLine("Please enter your target?");
                int UserInput;
                bool UserTarget = int.TryParse(Console.ReadLine(), out UserInput);

                int Start = 0;

                while (Start <= UserInput)
                {
                    Console.Write(Start + " ");
                    Start += 2;
                }

                do // loop/prompt until user enters Yes or No i.e will stay in loop until Yes or No
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, please say Yes or No");
                    }

                } 
                while (UserChoice != "YES" && UserChoice != "NO"); 
            } 
            while (UserChoice == "YES");

        }
    }
}
