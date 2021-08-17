using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;

 
namespace pragrimtech_c_sharp__vs_2019_
{

    public class Program
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3]
            {
                new Customer() { Name = "Mark", Gender = 1},
                new Customer() { Name = "Mary", Gender = 2 },
                new Customer() { Name = "Sam", Gender = 0 }
            };

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", 
                    customers[i].Name,
                    Customer.GetGender(customers[i].Gender));
            }

        }


    }


    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }

        public static string GetGender(int gender)
        {
            // 0 - Unkown
            // 1 - Male
            // 2 - Female
            // less readable should the application grow, which number correspond to which number?
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}



