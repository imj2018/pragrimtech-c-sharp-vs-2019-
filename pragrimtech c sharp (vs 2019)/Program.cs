using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerator = 10;
            int Denominator = 2;

            //int Result = Numerator / Denominator;
            int Result = Numerator % Denominator;

            int Number = 10;
            int AnotherNumber = 20;
            //if (Number == 10)
            //if (Number != 10)
            //if (Number == 10 && AnotherNumber == 20)
            if (Number == 10 || AnotherNumber == 20)
            {
                Console.WriteLine("Hello");
            }

            Console.WriteLine("Result = {0}", Result);

            int Number10 = 15;
            bool IsNumber10 = Number10 == 10 ? true : false;

            //if (Number10 == 10)
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}

            Console.WriteLine("Number == 10 is {0}", IsNumber10);



        }
    }
}
