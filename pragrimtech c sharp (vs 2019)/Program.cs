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

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = id;

        }

        public int GetId()
        {
            return this._id;

        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = name;
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

         
    }
  
    public class Program
    {
        public static void Main()
        {
            Student C1 = new Student();
            //C1.ID = -101;
            //C1.Name = null;
            //C1.PassMark = 0;
            C1.SetId(102);
            //C1.SetName("John");
            

            //C1.SetId(-1);

            //Console.WriteLine("ID = {0}",
            //    C1.GetId());

            //C1.SetName(null);

            Console.WriteLine(C1.GetId());
            Console.WriteLine(C1.GetName());
            Console.WriteLine(C1.GetPassMark());

        }
    }
}



