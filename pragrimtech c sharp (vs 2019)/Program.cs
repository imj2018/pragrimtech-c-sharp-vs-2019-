using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;

            //float f = i;

            float f = 12373473777388788.45f;

            //int i = (int)f;
            //int i = Convert.ToInt32(f); // type cast operator or convert class to throw exception

            //string strNumber = "100";
            //string strNumber = "100tg";
            string strNumber = "100"; 
            int result = 0;

            bool isConversionSuccesful = int.TryParse(strNumber, out result);
            //int i = int.Parse(strNumber); 

            if (isConversionSuccesful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }


        }
    }
}
