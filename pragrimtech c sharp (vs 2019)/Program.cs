using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;



namespace pragrimtech_c_sharp__vs_2019_
{
    class Circle
    {
        //float _Pi = 3.141f; // instance member

        // as Pi does not change value it can be set to static, there will always be just one copy in memory to be shared
        //static float _Pi = 3.141f;
        //static float _Pi;
        public static float _Pi;

        int _Radius;

        // static constructors cannot be public (cannot use access modifiers) anything in a class not public by default
        // is set to private and can only be accessed within the class
        // static constructors can be used to inilitialize static fields
        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            _Pi = 3.141f;
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }

        public static void Print()
        {
            //
        }

        public float CalculateArea()
        {
            //return this._Pi * _Radius * _Radius;
            return Circle._Pi * _Radius * _Radius;
        }

        public float CalculateCircumference()
        {
            return Circle._Pi * 2 * _Radius;
        }

    }
    class Program
    {
        public static void Main()
        {
            Circle C1 = new Circle(4);
            float area = C1.CalculateArea();

            // static members are invoked using the name 
            //Circle.Print();
            float circumference = C1.CalculateCircumference();
            Console.WriteLine(area);
            Console.WriteLine(circumference);

            // if there is no change on a pair object basis it should be converted to static as the value of pi will not change
            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();
            float circumference2 = c2.CalculateCircumference();
            Console.WriteLine(area2);
            Console.WriteLine(circumference2);

            // for testing purposes, this shows the static constructor is called first, before an instance constructor or any
            // static fields
            //Console.WriteLine(Circle._Pi);


        }
    }
}



