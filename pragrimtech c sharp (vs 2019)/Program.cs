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
                Name = "agent 47",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "illidan stormrage",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john 117",
                Salary = 3500
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "the warden",
                Salary = 4000
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "scorpion",
                Salary = 3000
            };


            //  objects will be added to the Queue one after another
            //  with Enqueue
            //
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            foreach (Customer c in queueCustomers)
            {
                Console.WriteLine(c.ID + " - " + c.Name);
                Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
            }
            Console.WriteLine("");

            //  Peek will return the item at the beginning of the Queue without
            //  removing
            //
            Customer cp = queueCustomers.Peek();
            Console.WriteLine(cp.ID + " - " + cp.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

            //  calling Peek again will still return the same object as it is not removed
            //
            Customer cp2 = queueCustomers.Peek();


            //  Contains to check for a specific item like other collections
            // 
            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exists");
            }
            else 
            {
                Console.WriteLine("customer1 does not exist");
            }


            //  to return an item from a Queue use Dequeue this will also
            //  remove the object at the beginning of the queue and then return
            //  it. unlike List or Dictonary the item is still in the collection
            //
            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

            Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + " - " + c2.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

            Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + " - " + c3.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);
            
            Customer c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.ID + " - " + c4.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

            Customer c5 = queueCustomers.Dequeue();
            Console.WriteLine(c5.ID + " - " + c5.Name);
            Console.WriteLine("Total Items in the Queue = " + queueCustomers.Count);

        }

    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }

    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Type { get; set; }


        #region
        //public string FirstName { get; set; }
        //public string LastName { get; set; }



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
                //this.FirstName == ((Customer)obj).FirstName &&
                //this.LastName == ((Customer)obj).LastName;
                false;
        }

        public override int GetHashCode()
        {
            //return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            return 0;
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



