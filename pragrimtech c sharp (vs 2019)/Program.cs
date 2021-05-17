using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        public static void Main()
        {
            Program Program = new Program();
            //program.EvenNumbers();

            Program.EvenNumbers(30);

            int Sum = Program.Add(3, 4);
            Console.WriteLine("Sum = {0}", Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        //public void EvenNumbers() // instance method 
        public static void EvenNumbers(int Target) // static method
        {
            int Start = 0;
            while (Start < Target)
            {
                if (Start % 2 == 1)
                {
                    continue;
                }
                //Console.WriteLine(Start);
                //Start = Start + 2;
                Start += 2;
                Console.WriteLine(Start);
            }

        }
    }
}
