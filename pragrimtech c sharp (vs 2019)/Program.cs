using System;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello");

            //ClassA.Print();
            //ProjectA.TeamB.ClassA.Print();
            //ProjectA.TeamA.ClassA.Print();

            // namespace readability,
            //PATA.ClassA.Print();
            //PATB.ClassA.Print();

            ProjectA.TeamA.ClassA.Print();



        }

    }
}
