using System;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Collections.ObjectModel;

/// <summary>
/// 
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Agent 47",
                Salary = 5000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Illidan Stormrage",
                Salary = 6500,
                Type = "RetailCustomer"

            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John 117",
                Salary = 3500,
                Type = "RetailCustomer"

            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "The Warden",
                Salary = 4000,
                Type = "CorporateCustomer"

            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Scorpion",
                Salary = 3000,
                Type = "CorporateCustomer"

            };

            List<Customer> customers = new List<Customer>(100)
            {
                customer1,
                customer2,
                customer3,

            };

            List<Customer> customersCorporate = new List<Customer>()
            {
                customer4,
                customer5

            };

            customers.AddRange(customersCorporate);



            











            //  mess around TrueForAll
            //if (!customers.TrueForAll(x => x.ID == 106))
            //{
            //    customers.Add(new Customer { ID = 106, Name = "arbiter" });
            //}

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //  mess around Sort delegate, pass lambdas
            Console.WriteLine("pass using the delegate keyword");
            customers.Sort(delegate (Customer c1, Customer c2)
            { return c1.ID.CompareTo(c2.ID); });


            //  simplified by passing a lambda, two customer objects (x,y) such
            //  that compare x.ID with y.ID
            //
            Console.WriteLine("pass a lambda");
            customers.Sort((x, y) => x.ID.CompareTo(y.ID));
            customers.Reverse();

            foreach (Customer item in customers)
            {
                Console.WriteLine(item.Name);
            }

        }

    }


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Type { get; set; }


        #region
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return
                this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;

        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();

        }

        public void AddNumbers(int firstNumber, int secondNumber, [Optional] params int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine("Sum = " + result);

        }
        #endregion


    }

    public enum Names
    {
        Agent47 = 101,
        IllidanStormrage = 102,
        MasterChief = 103,
        Warden = 104
    }

    public class SavingsCustomer : Customer
    {

    }



}



