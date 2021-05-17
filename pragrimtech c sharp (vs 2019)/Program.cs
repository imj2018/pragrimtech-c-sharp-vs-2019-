using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        public static void Main()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = {0} and Product - {1}", Total, Product);


            int[] Numbers = new int[3]
            {
                101,
                102,
                103
            };

            ParamsMethod();
            ParamsMethod(Numbers);         
            ParamsMethod(1, 2, 3, 4, 5); 

        }

        // output parameters when returning multiple values
        public static void Calculate(int FN, int SN, out int Sum, out int Product) 
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        //public static void ParamsMethod(int[] Numbers)
        // params keyword makes parameter optional
        // params can pass element values
        // must be the last parameter e.g ParamsMethod(int X, params int[] Numbers)
        // cannot have multiple ParamsMethod(params int[] Numbers, params string[] Names)
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }


    }
}
