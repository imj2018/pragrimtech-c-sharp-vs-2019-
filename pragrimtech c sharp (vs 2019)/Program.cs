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


            //  Stack is a generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace.
            //  The Stack collection class is analogous to a stack of plates. If you want to add a new plate to the stack of plates,
            //  you place it on top of all the already existing plates.If you want to remove a plate from the stack, you will first
            //  remove the one that you have last added. The stack collection class also operates in a similar fashion. The last item
            //  to be added (pushed) to the stack, will be the first item to be removed (popped) from the stack.
            
           
            //  Push will push the item to the top of the stack over the existing i.e customer5 will   
            //  be the last so it will be on top
            // 
            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);


            //  Peek works the same as Queue and will not remove the item
            //  
            Customer cp = stackCustomers.Peek();
            Console.WriteLine(cp.ID + " - " + cp.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //  Contains will also do the same and check if the object exists and return
            //  true or false
            // 
            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exists");
            }
            else
            {
                Console.WriteLine("customer1 does not exist");
            }


            foreach (Customer customer in stackCustomers)
            {
                Console.WriteLine(customer.ID + " - " + customer.Name);
                Console.WriteLine("Items left in the stack = " + stackCustomers.Count);
            }
            Console.WriteLine("");


            //  Pop will return and then remove the item at the top of the stack
            //
            Customer c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + " - " + c2.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c3 = stackCustomers.Pop();
            Console.WriteLine(c3.ID + " - " + c3.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c4 = stackCustomers.Pop();
            Console.WriteLine(c4.ID + " - " + c4.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c5 = stackCustomers.Pop();
            Console.WriteLine(c5.ID + " - " + c5.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);




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



