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
        public string City { get; set; }
        public string Email {
            get;
            set; 
        }


        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public int Id
        {
            set
            {
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

        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name found" : this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }

        }

        public int GetId()
        {
            return this._id;

        }

        public int GetPassMark()
        {
            return this._passMark;
        }



        public string GetName()
        {
            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No name found";
            //}
            //else
            //{
            //    return this._name;
            //}
            return string.IsNullOrEmpty(this._name) ? "No name found" : this._name;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = name;
        }


    }
  
    public class Program
    {
        public static void Main()
        {
            Student C1 = new Student();
            C1.Id = 117;
            C1.Name = "John";

            Console.WriteLine(C1.Id);
            Console.WriteLine(C1.Name);
            Console.WriteLine(C1.PassMark);

            // messing around
            Student[] students = new Student[2]
            {
                new Student() { Name = "Agent", Id = 47 },
                new Student() { Name = "John", Id = 117 }
            };

            foreach (var item in students)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Id);
            }
        }
    }
}



