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
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }



    }
   
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer(47, "agent");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.ID = 117;
            C2.Name = "john";
            C2.PrintDetails();

            Customer C3 = new Customer()
            {
                ID = 103,
                Name = "boba fett"
            };
            C3.PrintDetails();


            // messing around
            //Student[] students = new Student[2]
            //{
            //    new Student() { Name = "agent", Id = 47 },
            //    new Student() { Name = "john", Id = 117 }
            //};

            //foreach (var item in students)
            //{
            //    Console.WriteLine("{0} {1}", item.Name, item.Id);
            //}
        }
    }
}



