using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    // structs are sealed, cannot inherit from struct
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

        //public Customer() { }

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", 
                this._id, this._name);
        }

        //~Customer()
        //{

        //}


    }
   
    public class Program
    {
        public static void Main()
        {
            //int i = 10;

            //if (i == 10)
            //{
            //    int j = 20;
            //    Customer C1 = new Customer()
            //    {
            //        ID = 47,
            //        Name = "agent"
            //    };
            //    Console.WriteLine("in the scope of if block {0}", C1.ID);
            //}
            //Console.WriteLine("in the scope of Main");

            int i = 10;

            // j will copy the value, it will not affect i as they are two
            // different copies
            int j = i;
            j = j + 1;

            Console.WriteLine("i = {0} && j = {1}", i, j);

            Customer C1 = new Customer()
            {
                ID = 47,
                Name = "agent"
            };

            // referencing same object
            Customer C2 = C1;
            C2.Name = "john";

            Console.WriteLine("C1.Name = {0} && C2.Name = {1}", 
                C1.Name, C2.Name);

        }
    }
}



