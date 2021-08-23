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


            //  previously we were adding one item at a time, AddRange
            //  will add a List to another List
            //customers.AddRange(customersCorporate);

            foreach (Customer customer in customers)
            {
                //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                //    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("");


            //  from index position 3 I want 2 items 
            //  index 3 is item 4, including that item at index 3 (customer4) for the
            //  count so customer4, customer5 i.e all CorporateCustomer type
            //List<Customer> getCorporateCustomer = customers.GetRange(3, 2);

            //foreach (Customer customer in getCorporateCustomer)
            {
                //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                //    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("");


            //  I want only the RetailCustomers, from index 0 I want 3 (including 0)
            List<Customer> getRetailCustomers = customers.GetRange(0, 3);

            foreach (Customer customer in getRetailCustomers)
            {
                //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                //    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("");


            //  insert a List at a position i.e 0 so the top
            //customers.InsertRange(0, customersCorporate);

            //  insert by index to the bottom of the List
            customers.InsertRange(3, customersCorporate);

            //customers.Remove(customer1);

            //customers.RemoveAt(1);

            //  to remove all items using a predicate/lambda to remove all
            //  CorporateCustomer type
            customers.RemoveAll(cc => cc.Type == "CorporateCustomer");

            //  from index 3whatever remove those items
            //customers.RemoveRange(3, 2);
            customers.RemoveRange(0, 3);

            foreach (Customer customer in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("");






        }

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





}



