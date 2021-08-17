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
                new Customer() { Name = "Mark", Gender = Gender.Male},
                new Customer() { Name = "Mary", Gender = Gender.Female },
                new Customer() { Name = "Sam", Gender = Gender.Unkown }
            };

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", 
                    customers[i].Name,
                    Customer.GetGender(customers[i].Gender));
            }

        }

    }

    public enum Gender
    {
        Unkown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public static string GetGender(Gender gender)
        {
            // 0 - Unkown
            // 1 - Male
            // 2 - Female
            // less readable should the application grow, which number correspond to which number?)
            switch (gender)
            {
                //case 0:
                //    return "Uknown";
                case Gender.Unkown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}



