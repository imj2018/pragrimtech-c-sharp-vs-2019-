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

            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Numbers in descending order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabet = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabet before sorting");
            foreach (string letter in alphabet)
            {
                Console.WriteLine(letter);
            }

            alphabet.Sort();

            Console.WriteLine("Alphabet after sorting");
            foreach (string letter in alphabet)
            {
                Console.WriteLine(letter);
            }

            alphabet.Reverse();

            Console.WriteLine("Alphabet in descending order");
            foreach (string letter in alphabet)
            {
                Console.WriteLine(letter);
            }


            //  attempting to use Sort on custom/complex types (Customer List)
            //  will throw an exception as .NET does not know how to sort complex types
            //  .NET needs to be told how to sort them at run time
            //
            //  simple types already implement IComparable and have a CompareTo method
            //  within the .NET framework
            // 
            customers.Sort();









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



