using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;

/// <summary>
/// inspect an assembly's contents by lopking at the meta data at runtime
/// is reflection
///  
/// late binding is creating an instance of a class at runtime rather than
/// compile time, this can be done using reflection
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{
    public class Program
    {

        public static void Main()
        {
            // we have knowledge of the Customer class at compile time like so
            // i.e early binding, but there is a possibility that you may
            // not know the class at runtime e.g assembly is not available.
            // so a class needs to be created at runtime dynamically i.e late binding
            // a way to handle this is through reflection
            //Customer C1 = new Customer();

            // using the Type class to get the type of class Customer
            //Type T = Type.GetType("pragrimtech_c_sharp__vs_2019_.Customer");

            // can also use tyepof
            //Type T = typeof(Customer);

            // if given the instance of the class instead of the class itself
            // all objects have GetType inherited from System.Object
            Customer C1 = new Customer();
            Type T = C1.GetType();

            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace  = {0}", T.Namespace);
            Console.WriteLine();

            // PropertyInfo and Method info are from System.Reflection
            Console.WriteLine("Properies in Customers");
            PropertyInfo[] properties = T.GetProperties();
            foreach (var property in properties)
            {
                //Console.WriteLine(property.Name);
                Console.WriteLine(property.PropertyType + " " + property.Name);

            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customers");
            MethodInfo[] methods = T.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);

            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customers");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (var constructor in constructors)
            {
                //Console.WriteLine(constructor.Name);
                Console.WriteLine(constructor.ToString());

            }
        }

    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
         
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }

    }

 
}



