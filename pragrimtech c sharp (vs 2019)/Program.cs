using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;

 

namespace pragrimtech_c_sharp__vs_2019_
{

    /// <summary>
    /// classes, structs, enums, interfaces, delegates are called types
    /// fields, properties, constructors, methods etc are called type members
    /// 
    /// </summary>
    public class Customer
    {
        #region Fields
        private int _id;
        private string _firstName;
        private int _lastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public int LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion  
    }

    public class Program
    {

        public static void Main()
        {
             

        }

    }

}



