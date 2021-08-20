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
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Illidan Stormrage",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John 117",
                Salary = 3500
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "The Warden",
                Salary = 4000
            };


            //  key will be the ID which is type int, the value type is the Customer object itself
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);
            dictionaryCustomers.Add(customer4.ID, customer4);

            // key must be unique, check with ContainsKey which returns a bool
            if (!dictionaryCustomers.ContainsKey(customer1.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer1);
            }

            // will throw a runtime error if a key does not exist
            if (dictionaryCustomers.ContainsKey(135))
            {
                Customer customerDoesNotExist = dictionaryCustomers[135];
            }


            //  opening square brackets automatically prompts for the key (Customer ID
            //  of type int) 
            // 
            //  a customer object is returned
            //dictionaryCustomers[047];         
            Customer customer47 = dictionaryCustomers[101];

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", 
                customer47.ID, customer47.Name, customer47.Salary);
            Console.WriteLine("");


            //  a Dictionary is a collection of key value pairs
            //  the type of the key ID is int, the value type is Customer 
            //
            //  avoid var, easier to explicitely state KeyValuePair<int, Customer>
            //  to know the type
            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);

                //  Value is returning a Customer object
                Customer customer = customerKeyValuePair.Value;

                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", 
                    customer.ID, customer.Name, customer.Salary);
                Console.WriteLine("--------------------------------------------------------");
            }
            Console.WriteLine("");


            // just get keys
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("");

            // just get values 
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", 
                    customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("");


        }

    }


    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


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

    }





}



