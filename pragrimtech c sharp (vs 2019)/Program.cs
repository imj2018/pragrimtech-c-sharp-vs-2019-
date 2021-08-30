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
using System.Threading;
using System.Diagnostics;

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
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Mark"},
                new Employee() { ID = 102, Name = "John"},
                new Employee() { ID = 103, Name = "Mary"},

            };

            //  created an instance of a delegate pointing to a method,
            //  Predicate requires a method that matches i.e returns bool
            //  and expects and object of type Employee as a parameter
            //
            // Step 2
            //Predicate<Employee> employeePredicate = 
            //    new Predicate<Employee>(FindEmployee);

            // Step 3
            //Employee employee = listEmployees.Find(emp => FindEmployee(emp));

            //  anonymous method
            Employee employee = listEmployees.Find(delegate(Employee emp)
            {
                return emp.ID == 102;
            });

            Console.WriteLine(" Id = {0}, Name = {1}", employee.ID, employee.Name);

            
        }

        // Step 1
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}

    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }












    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;

        public AccountManager( Account fromAccount, Account toAccount, 
            double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;

        }
        public void Transfer()
        {

            object _lock1, _lock2;

            if (_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }

            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " +
                ((Account)_lock1).ID.ToString());

            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquire lock on " +
                    ((Account)_lock1).ID.ToString());

                Console.WriteLine(Thread.CurrentThread.Name + " suspend for 1 second");
                Thread.Sleep(1000);

                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " +
                   ((Account)_lock2).ID.ToString());

                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquire lock on " +
                 ((Account)_lock2).ID.ToString());
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + " Transferred " + _amountToTransfer.ToString() +
                        " from " + _fromAccount.ToString() + " to " + _toAccount.ID.ToString());

                }
            }
        }
    }

    public class Account
    {
        double _balance;
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;

        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

    }


    public class Number
    {
        private int _target;
        public void PrintSumOrNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= _target; i++)
            {
                sum += i;
                //Console.WriteLine(i);
            };

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



