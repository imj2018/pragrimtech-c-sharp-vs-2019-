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

            //Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            //dictionaryCustomers.Add(customer1.ID, customer1);
            //dictionaryCustomers.Add(customer2.ID, customer2);
            //dictionaryCustomers.Add(customer3.ID, customer3);
            //dictionaryCustomers.Add(customer4.ID, customer4);

            Dictionary<int, Customer> dictionaryCustomers =
                new Dictionary<int, Customer>()
                {
                    { customer1.ID, customer1 },
                    { customer2.ID, customer2 },
                    { customer3.ID, customer3 },
                    { customer4.ID, customer4 },
                };

            //dictionaryCustomers[101];

            Customer c1;

            //  if there is a key 101 the second parameter will receive the value
            //  based on the key (out paramter)
            //dictionaryCustomers.TryGetValue(101, out c1)
            if(dictionaryCustomers.TryGetValue(111, out c1))
            {
                Console.WriteLine("{0}  {1}  {2}", 
                    c1.ID, c1.Name, c1.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }
            Console.WriteLine("");

            //  counts all the items and returns an int 
            //Console.WriteLine("Total items = {0}", dictionaryCustomers.Count);

            //  the Count method is different i.e a LINQ extension method
            //
            //  pass a predicate, kvp (key value pair) such that kvp.Value.Salary > 4000
            //  if true that employee will be included in the Count
            Console.WriteLine("Total items = {0}", 
                dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));

            int c2 = dictionaryCustomers.Count(kvp => kvp.Value.ID == (int)Names.IllidanStormrage);
            Console.WriteLine(c2);

            //  remove item based on ID
            //dictionaryCustomers.Remove(103);

            //  remove all items
            //dictionaryCustomers.Clear();


            //  convert an array to a Dictionary
            Customer[] customersArray = new Customer[3]
            {
                customer1,
                customer2,
                customer3
            };

            // converting from a List to a Dictionary will be the same
            List<Customer> customersList = new List<Customer>()
            {
                customer1,
                customer2,
                customer3
            };

            // the key will be Customer ID, the value will be a customer object
            // 
            // ToDictionary will return a Dictionary
            Dictionary<int, Customer> dictionaryConversion =
                //customersArray.ToDictionary(cust => cust.ID, cust => cust);
                customersList.ToDictionary(cust => cust.ID, cust => cust);



            foreach (KeyValuePair<int, Customer> kvp in dictionaryConversion)
            {
                Console.WriteLine("Key = {0}", kvp.Key);

                Customer customer = kvp.Value;
                Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}", 
                    customer.ID, customer.Name, customer.Salary);
            }







            //  messing around
            foreach (KeyValuePair<int, Customer> customer in dictionaryCustomers)
            {
                //Console.WriteLine(customer.Value.Name);
            }
            //Console.WriteLine("");

        }

    }

    public enum Names
    {
        Agent47 = 101,
        IllidanStormrage = 102, 
        MasterChief = 103,
        Warden = 104 
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



