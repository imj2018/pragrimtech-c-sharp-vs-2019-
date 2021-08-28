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

/// <summary>
/// 
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{

    public delegate void SumOfNumberCallback(int SumOfNumbers);

    public class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }
        public static void Main()
        {

            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumberCallback callback = new SumOfNumberCallback(PrintSum);

            Number number = new Number(target, callback); 

            Thread T1 = new Thread(number.PrintSumOrNumbers);
            T1.Start();


        }
        
    }

    public class Number
    {
        private int _target;
        SumOfNumberCallback _callBackMethod;

        public Number(int target, SumOfNumberCallback callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }
        public void PrintSumOrNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= _target; i++)
            {
                sum += i;
                //Console.WriteLine(i);
            };

            //  hand the sum over to the _callBackMethod delegate
            //  which is pointing to PrintSum which will just print
            //  the sum
            // 
            if (_callBackMethod != null)
            {
                _callBackMethod(sum);
            }


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



