using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start += 2;
            }


        }
    }
}
