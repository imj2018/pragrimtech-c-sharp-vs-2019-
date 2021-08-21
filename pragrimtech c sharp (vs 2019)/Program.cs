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


            List<Customer> customers = new List<Customer>()
            {
                customer1,
                customer2,
                customer3,

            };

            //  returns a bool and checks if objects exists, can't pass a condition
            if(customers.Contains(customer3))
            {
                Console.WriteLine("Customer3 object exists in the list");

            }
            else
            {
                Console.WriteLine("Customer3 object does not exists in the list");
            }
            Console.WriteLine("");


            //  also expects a predicate/lambda but only returns the first matching
            //  item
            if (customers.Exists(c => c.Name.StartsWith("I")))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("");


            //  unlike Contains, Exists that will only tell you if the object exists
            //  an actual object is returned not a bool
            Customer c = customers.Find(c => c.Salary > 4000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary); ;
            Console.WriteLine("");


            // find the last matching item based on condition
            Customer cl = customers.FindLast(cl => cl.Salary > 4000);
            Console.WriteLine("");


            List<Customer> cA = customers.FindAll(cA => cA.Salary > 4000);
            foreach (var customer in cA)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                    customer.ID, customer.Name, customer.Salary);

            }
            Console.WriteLine("");

            //  only return index of the first matching item
            int index = customers.FindIndex(cA => cA.Salary > 4000);

            //  specify starting index (starting index 2)
            index = customers.FindIndex(2, cA => cA.Salary > 2000);

            //  id doesn't exist -1
            if (index > 0)
            {
                Console.WriteLine("Index = {0}, Name = {1}", index, customers[index].Name);
            }
            Console.WriteLine("");

            //  can also use count for how many items/ range of those elements to look up
            //  start index, count, predicate
            index = customers.FindIndex(1, 2, cA => cA.Salary > 2000);
            Console.WriteLine("Index = {0}, Name = {1}", index, customers[index].Name);
            Console.WriteLine("");

            index = customers.FindLastIndex(cA => cA.Salary > 2000);
            Console.WriteLine("Index = {0}, Name = {1}", index, customers[index].Name);
            Console.WriteLine("");


            Customer[] customerArray = new Customer[3]
            {
                customer1,
                customer2,
                customer3
            };

            //  convert array to List
            List<Customer> customersList = customerArray.ToList();
            foreach (var customer in customersList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                    customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("");

            //  conver back to array
            Customer[] customersBackToArray = customersList.ToArray();

            //  convert List to a Dictionary, the key needs to be specified and the value,
            //  the value is optional and by default if no value is specified it will use
            //  the object (Customer object)
            Dictionary<int, Customer> customersDictonary = 
                customersList.ToDictionary(c => c.ID, c => c);

            foreach (KeyValuePair<int, Customer> kvp in customersDictonary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer customer = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                    customer.ID, customer.Name, customer.Salary);
            }
            Console.WriteLine("");



            //  practice Dictionary collection
            //Dictionary<int, Customer> dictionaryCustomers =
            //    new Dictionary<int, Customer>()
            //    {
            //        {customer1.ID, customer1 },
            //        {customer2.ID, customer2 },
            //        {customer3.ID, customer3 },
            //        {customer4.ID, customer4 },

            //    };

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



