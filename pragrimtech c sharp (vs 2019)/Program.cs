using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;
using System.IO;

class Circle
{
    //static float _PI = 3.141f;
    public static float _PI;

    int _Radius;

    public Circle(int Radius)
    {
        Console.WriteLine("Instance Constructor Called");
        this._Radius = Radius;
    }

    static Circle()
    {
        Console.WriteLine("Static Constructor Called");
        Circle._PI = 3.141f;
    }

    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius; 
    }

    public static void Print()
    {
        //
    }

}


namespace pragrimtech_c_sharp__vs_2019_
{
    class Pragim
    {
        public static void Main()
        {
            //Circle C1 = new Circle(5);
            //float Area = C1.CalculateArea();
            //Circle.Print();

            //Console.WriteLine("Area = {0}", Area);

            //Circle C2 = new Circle(6);
            //float Area2 = C2.CalculateArea();

            //Console.WriteLine("Area = {0}", Area2);

            Console.WriteLine(Circle._PI);
        }

    }

}







