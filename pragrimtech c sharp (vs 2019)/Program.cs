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
        // encapsulation
        private int _id;
        private string _name;

        // as there is only a get method/return it is essentially readonly
        private int _passMark = 35;

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            else
            {
                this._name = Name;
            }
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;

            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            else
            {
                this._id = Id;
            }
        }

    }

    public class Program
    {
        public static void Main()
        {
            Student S1 = new Student()
            {

            };

            S1.SetId(101);

            //Console.WriteLine("ID = {0} && Name = {1} PassMark = {2}",
            //    S1.ID, S1.Name, S1.PassMark);

            Console.WriteLine("Student Id = {0}", S1.GetId());
            Console.WriteLine("Student Name = {0}", S1.GetName());
            Console.WriteLine("Student Pass Mark = {0}", S1.GetPassMark());


        }
    }

}



