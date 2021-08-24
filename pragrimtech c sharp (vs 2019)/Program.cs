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
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washigton D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            #region
            //  using a List/this approach is not as efficient for this scenario as we it loop through each value
            //  and check a Dictionary is much more efficient for Finding objects/valyes using keys
            //
            //List<Country> listCountries = new List<Country>()
            //{
            //    country1,
            //    country2,
            //    country3,
            //    country4,
            //    country5
            //};

            //  do all this while some condition
            // 
            //  the user choice needs to be declared outside of scope
            //
            //string strUserChoice = "";

            //do
            //{
            //    Console.WriteLine("Please enter country Code");
            //    string strCountryCode = Console.ReadLine().ToUpper();

            //    //  return a Country object based on what user has passed using Find based
            //    //  on the predicate/lambda
            //    //
            //    Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Country code not valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            //    }

            //    do
            //    {
            //        Console.WriteLine("Do you want to continue - YES or NO?");
            //        strUserChoice = Console.ReadLine().ToUpper();
            //    }
            //    while (strUserChoice != "YES" && strUserChoice != "NO");

            //}

            //while (strUserChoice == "YES");
            #endregion

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>()
            {
                { country1.Code, country1 },
                { country2.Code, country2 },
                { country3.Code, country3 },
                { country4.Code, country4 },
                { country5.Code, country5 },

            };


            //do all this while some condition

            //the user choice needs to be declared outside of scope


            string strUserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter country Code");
                string strCountryCode = Console.ReadLine().ToUpper();

                //  return a Country object back
                // 
                //  an exception will be thrown if the key is not found so ContainsKey
                //  can be used to check 
                //
                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) 
                    ? dictionaryCountries[strCountryCode]
                    : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }

                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "YES" && strUserChoice != "NO");

            }

            while (strUserChoice == "YES");





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



