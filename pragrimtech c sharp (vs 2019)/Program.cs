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


            //  out of range exception, arrays do not grow in size
            //Customer[] customers = new Customer[2]
            //{
            //    customer1,
            //    customer2,
            //    customer3
            //};


            //  can set a size to a List like so List<Customer>(2)
            //  but the size will automatically grow beyond the set amount
            List<Customer> customers = new List<Customer>(2)
            {
                customer1,
                customer2,
                customer3,
                //sc 

            };

            //  strongly typed cannot add any type must be Customer
            //customers.Add(101);

            //  though strongly typed but possible to add a class that is inherited
            //  i.e SavingsCustomer inherits from Customer so it can be added
            SavingsCustomer sc = new SavingsCustomer();
            //customers.Add(sc);

            //  insert an object at a specific location, doing so will push the other
            //  objects further down 
            customers.Insert(0, customer3);

            foreach (var item in customers)
            {
                Console.WriteLine(item.ID);
            }
            Console.WriteLine("");


            //  IndexOf to get the index of an item in the List
            //  index 0 is returned, customer3 is pointed from 2 positions (0 and 3) but it will
            //  return the first by default
            //int position = customers.IndexOf(customer3);

            //  second parameter can denote where to start, from position 1 it will start looking
            //  and return index 3 (last position of customer3)
            //position = customers.IndexOf(customer3, 1);

            //  third parameter can denote how many elements to look for i.e from position
            //  how many many elements to look through
            int position = customers.IndexOf(customer3, 1, 4);

            Console.WriteLine("Position = {0}", position);
            Console.WriteLine("");


            Customer c = customers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ",
                c.ID, c.Name, c.Salary);
            Console.WriteLine("");

            foreach (Customer customer in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ",
                    customer.ID, customer.Name, customer.Salary);

            }
            Console.WriteLine("");

            //  <= can cause an out of bounds exception as the Count is 3
            //  when <= is 4 (0, 1, 2, 3) so foreach should be used when 
            //  just needing to loop through a collection
            for (int i = 0; i < customers.Count; i++)
            {
                //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ",
                //    customers[i].ID, customers[i].Name, customers[i].Salary);

                Customer customer = customers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ",
                    customer.ID, customer.Name, customer.Salary);

            }
            Console.WriteLine("");







            //  practice Dictionary collection
            Dictionary<int, Customer> dictionaryCustomers =
                new Dictionary<int, Customer>()
                {
                    {customer1.ID, customer1 },
                    {customer2.ID, customer2 },
                    {customer3.ID, customer3 },
                    {customer4.ID, customer4 },

                };


            foreach (KeyValuePair<int, Customer> keyValuePair in dictionaryCustomers)
            {
                int key = keyValuePair.Key;
                Customer customer = keyValuePair.Value;

                Console.WriteLine("Key = {0}", key);
                //Console.WriteLine("{0}  {1}  {2} ", keyValuePair.Value.ID, 
                //    keyValuePair.Value.Name, keyValuePair.Value.Salary);
                Console.WriteLine("{0}  {1}  {2} ", customer.ID, 
                    customer.Name, customer.Salary);

            }

            dictionaryCustomers.Count(c => c.Value.Name == "The Warden");

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



