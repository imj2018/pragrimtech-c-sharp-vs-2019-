using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;

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
            // early binding 
            // errors are detected at compile time
            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Pragim", "Tech");
            //Console.WriteLine("Full Name = {0}", fullName);

            // late binding, when knowledge of the class/object is unavailable
            // only use late binding with objects that are not available at compile time
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            
            // returning/get the type
            Type customerType = executingAssembly.GetType("pragrimtech_c_sharp__vs_2019_.Customer");

            // Activator will create an instance of the Customer class
            // object as we don't know what it is
            // if it were static likely just the type is required
            object customerInstance = Activator.CreateInstance(customerType);

            // return an object of type MethodInfo
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Pragim";
            parameters[1] = "Technologies";

            // Invoke needs the class instance/object and parameters
            // second parameter is expecting an object[] not a string but string
            // directly/indirectly inherits from object so it can be used
            //string fullName = (getFullNameMethod.Invoke(customerInstance, parameters).ToString();
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0}", fullName);

        }

    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }

    }


}



