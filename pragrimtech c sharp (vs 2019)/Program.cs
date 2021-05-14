using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }

            //if (UserNumber == 2) // will still check if first condition is true
            //{
            //    Console.WriteLine("Your number is two");
            //}

            //if (UserNumber == 3)
            //{
            //    Console.WriteLine("Your number is three");
            //}

            else if (UserNumber == 2) // if condition is true skip the rest, faster
            {
                Console.WriteLine("Your number is two");
            }

            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }

            //if (UserNumber != 1 && UserNumber != 2 && UserNumber !=3)
            //{
            //    Console.WriteLine("Your number is not between 1 and 3");
            //}
            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }


            //if (UserNumber == 10 || UserNumber == 20) // if first condition is true continue, faster
            //if (UserNumber == 10 | UserNumber == 20) // will check both conditions even if first is condition is true
            //if (UserNumber == 10 && UserNumber == 20) // if first condition is false, skip second
            if (UserNumber == 10 & UserNumber == 20) // // will check both

            {
                Console.WriteLine("Your number is 10 or 20");
            }
            else
            {

            }


        }
    }
}
