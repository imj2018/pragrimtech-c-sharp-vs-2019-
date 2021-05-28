using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    public struct Customer
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.ID = Id;
            this.Name = Name;
        }

        public void PrintDetail()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this.ID, this.Name);
        }

    }



    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer(101, "Mark");
            C1.PrintDetail();

            Customer C2 = new Customer();
            C2.ID = 102;
            C2.Name = "John";
            C2.PrintDetail();

            Customer C3 = new Customer()
            {
                ID = 103,
                Name = "Joe"
            };
            C3.PrintDetail();

        }
    }

}



