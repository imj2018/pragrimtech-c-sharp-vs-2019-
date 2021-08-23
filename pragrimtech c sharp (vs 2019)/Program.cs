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

            List<Customer> customers = new List<Customer>()
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


            //  the constructor of Comparison (Comparison delegate expects a function
            //  that returns a type integer and Customer object parameters. the name
            //  of function CompareCustomer can be passed 
            //
            Comparison<Customer> customerComparer =
                new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID);
            }


            //  expecting a Comparison delegate
            //
            Console.WriteLine("After Sorting");
            customers.Sort(customerComparer);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID);
            }


            //  simplified by passing by using the delegate keyword directly
            // 
            Console.WriteLine("pass using the delegate keyword");
            customers.Sort(delegate(Customer c1, Customer c2)
            { return c1.ID.CompareTo(c2.ID); });


            //  simplified by passing a lambda, two customer objects (x,y) such
            //  that compare x.ID with y.ID
            //
            Console.WriteLine("pass a lambda");
            customers.Sort((x, y) => x.ID.CompareTo(y.ID));


        }

        private static int CompareCustomer(Customer x, Customer y)
        {
            //  compare ID of Customer object x with y
            //
            return x.ID.CompareTo(y.ID);
        }

    }


    //  in real time you may not own the class code but you need to change
    //  the default Sort functionality, IComparer can be used which has a Compare method
    //
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            //  Name is string so CompareTo can be used to return an int
            return x.Name.CompareTo(y.Name);
        }
    }

    //  implement IComparableInterface
    //
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Type { get; set; }

        //  compare the instance of this class to the object passed with CompareTo
        //  
        //  if the number returned is > 0 than the instance is greater than the object
        //  compared with
        //  if < 0 than object is less, if 0 than equal
        //
        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary)
            //{
            //    return 1;
            //}
            //else if (this.Salary < other.Salary)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            //  as int already has a CompareTo the if check is not needed
            //  and you can just compare to the Customer object salary passed
            // 
            //return this.Salary.CompareTo(other.Salary);

            //  string also has CompareTo so Name can be used
            //
            //return this.Name.CompareTo(other.Name);

            return this.Salary.CompareTo(other.Salary);
        }

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



}



