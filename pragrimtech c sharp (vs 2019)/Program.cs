using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;
using System.IO;

public delegate void SampleDelegate(out int Number);


namespace pragrimtech_c_sharp__vs_2019_
{

    class Pragim
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                // changing the directory will throw a directory not found and require
                // a different exception (not FileNoteFoundException)
                streamReader = new StreamReader(@"C:\Users\miral\Desktop\data.txt");

                Console.WriteLine(streamReader.ReadToEnd());

                //streamReader.Close();
            }
            //catch (Exception ex)
            catch (FileNotFoundException ex)
            {
                // log to a database, send to error to admin etc
                // the parent Exception class does not have the FileName property
                Console.WriteLine("Please check if the file {0} exists", ex.FileName); 
                //Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            // practical application of inheritance, Exception is the parent class to all exceptions
            // and can point to any derived
            // specific inheritance/exceptions at the top and the general at the bottom
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // though finally is optional, without a finally block and there is a FileNotFoundException
            // it will not execute the rest of the code, resources will not be released
            //if (streamReader != null)
            //{
            //    streamReader.Close();
            //}
            //Console.WriteLine("Finally Block");

            // because of the directory exception, the code to release/streamReader.Close will
            // never execute therefore release them in the finally which will execute whether there
            // is an exception or not
            finally
            {

                // if check is required, if StreamReader cannot get the data from the fill it will be
                // null and throw a null exception
                if (streamReader != null)
                {
                    streamReader.Close();
                }             
                Console.WriteLine("Finally Block");
            }


        }

    }

}







