using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        public static void Main()
        {
            int i = 0;
            //SimpleMethod(i); // pass by value, pointing to different memery location, 0 is copied into variable
            SimpleMethod(ref i); // i and j are pointing to same memory location, though i is set to 0 j is setting it to 101

            Console.WriteLine(i);

            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = {0} and Product = {1}", Total, Product);
        }

        //public static void SimpleMethod(int j)
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        public static void Calculate(int fn, int sn, out int Sum, out int Product)
        {
            Sum = fn + sn;
            Product = fn * sn;
        }
    }
}
