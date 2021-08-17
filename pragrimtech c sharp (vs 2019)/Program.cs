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
    /// protected can be used in the derived class and containing class and 
    /// 
    /// </summary>
    public class Customer
    {
        //private int _id;

        //public int Id
        //{
        //    get 
        //    { 
        //        return _id; 
        //    }
        //    set 
        //    { 
        //        _id = value; 
        //    }
        //}
  
        protected int ID;

        public void TestContainMethod()
        {
            Console.WriteLine(this.ID);

        }

    }

    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            // can use a derived class object to access the protected fields
            // base.ID or this.ID
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
            base.ID = 101;
            this.ID = 101;
        }
    }

    public class Program
    {

        public static void Main()
        {
            Customer C1 = new Customer();
            //C1._id
            //C1.ID = 1;
        }

    }

}



