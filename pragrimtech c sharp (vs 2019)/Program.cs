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

            StreamReader streamReader = null;
            try
            {
                streamReader = 
                    new StreamReader(@"C:\Users\miral\source\repos\pragrimtech-c-sharp-vs-2019-\pragrimtech c sharp (vs 2019)\data1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch (FileNotFoundException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);

                // Log the details to the DB
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);

            }
            // an example of inheritance, practical application of inheritance, specific exceptions at the top
            // general at the bottom
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }
        }




    }
}



