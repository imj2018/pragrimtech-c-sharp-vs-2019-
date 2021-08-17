using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;


namespace pragrimtech_c_sharp__vs_2019_
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0} ", Result);
                }
                catch (Exception ex)
                { 
                    // write exception to file
                    string filePath = @"C:\Users\miral\source\repos\pragrimtech-c-sharp-vs-2019-\pragrimtech c sharp (vs 2019)\log1.txt";

                    // if the log file to store error information is found
                    // inner exception
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a Problem, Please try later");
                    }
                    else
                    {
                        // outer exception
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }

                }


            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);

                }

            }

        }

    }
}



