using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        //private string _city;
        //private string _email;


        //public string City
        //{
        //    get
        //    {
        //        return this._city;
        //    }
        //    set
        //    {
        //        this._city = value;
        //    }
        //}

        //public string Email
        //{
        //    get
        //    {
        //        return this._email;
        //    }
        //    set
        //    {
        //        this._email = value;
        //    }
        //}

        // compiler creates fields behined the scenes
        public string City
        {
            get;
            set;
        }

        public string Email { get; set; }



        public int PassMark
        {
            // only get accessory so readonly
            get
            {
                return this._passMark;
            }
        }

        public string Name // read, write property
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int Id
        {
            set
            {
                // the value keyword is used to receive set the value to the property
                // i.e set Id = 101
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }

        }

    }

    public class Program
    {
        public static void Main()
        {
            Student S1 = new Student();

            // set like a field not a method, no need to create get and set methods
            S1.Id = 101;
            S1.Name = "Mark";
            //S1.PassMark = 10;


            Console.WriteLine("Student Id = {0}", S1.Id);
            Console.WriteLine("Student Name = {0}", S1.Name);
            Console.WriteLine("Student Pass Mark = {0}", S1.PassMark);


        }
    }

}



