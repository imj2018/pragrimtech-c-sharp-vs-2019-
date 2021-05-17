using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[]
            {
                101,
                102,
                103,
                104
            };

            // take each element out of collection and put in variable (item)
            foreach (var item in Numbers) 
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("remainder is " + 0 % 2);
            Console.WriteLine("remainder is " + 1 % 2);
            Console.WriteLine("remainder is " + 2 % 2);
            Console.WriteLine("remainder is " + 3 % 2);
            Console.WriteLine("remainder is " + 4 % 2);

            //for (int i = 1; i <= 10; i+=2)
            for (int i = 0; i <= 20; i++)
            {
                // for every off number condition is true
                // 0 ÷ 2 remainder 0
                // 1 ÷ 2 has a remainder so continue i.e skip there rest of loop and go back to the start
                // 2 ÷ 2 has no remainder skip etc
                if (i % 2 == 1) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 20)
                {
                    // control will get out of loop
                    break; 
                }
            }


            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == Numbers[2])
                {
                    Console.WriteLine("at element 3");
                }
                Console.WriteLine(Numbers[i]);
            }


            int counter = 0;

            // length of array 3
            while (counter < Numbers.Length) 
            {
                Console.WriteLine(Numbers[counter] + " ");
                counter++;
            }



  

        }
    }
}
