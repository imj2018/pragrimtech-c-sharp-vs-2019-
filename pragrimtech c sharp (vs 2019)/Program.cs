using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbertwo = "2";
            int result;
            int.TryParse(numbertwo, out result);

            int[] EvenNumbers = new int[3];
            int[] OddNumbers = { 1, 3, 5, };

            EvenNumbers[0] = 0;
            EvenNumbers[1] = result;
            EvenNumbers[2] = 4;
            //EvenNumbers[3] = 6; // can't grow in size over time/once initialized

            Console.WriteLine(EvenNumbers[1]);
            //Console.WriteLine(EvenNumbers[10]);



        }
    }
}
