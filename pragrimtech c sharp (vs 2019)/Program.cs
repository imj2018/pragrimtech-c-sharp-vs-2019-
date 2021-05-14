using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 10)
            //{
            //    Console.WriteLine("Your number is 10");
            //}
            //else if (UserNumber == 10)
            //{
            //    Console.WriteLine("Your number is 10");
            //}
            //else if (UserNumber == 10)
            //{
            //    Console.WriteLine("Your number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not 10, 20 or 30");
            //}

            switch (UserNumber)
            {
                //case 10:
                //    Console.WriteLine("You number is 10");
                //    break;
                //case 20:
                //    Console.WriteLine("You number is 20");
                //    break;
                case 10:
                case 20:
                case 30:
                    //Console.WriteLine("You number is 30");
                    Console.WriteLine("You number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("You number is not 10, 20 or 30");
                    break;
            }
        }
    }
}
