using System;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = null;

            //int i = null; 
            int? i = null;

            bool? AreyouMajor = null;

            //if (AreyouMajor.Value)
            if (AreyouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (!AreyouMajor == false)
            {
                Console.WriteLine("User is NOT Major");

            }
            else
            {
                Console.WriteLine("User did answer the Question");
            }


            int? TicketsOnSale = null;
            int AvailableTickets = TicketsOnSale ?? 0; // ?? null coalescing operator 

            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    //AvailableTickets = TicketsOnSale.Value;
            //    AvailableTickets = (int)TicketsOnSale; // convert nullable (int?) to non nullable, cannot hold null
            //}

            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

        }
    }
}
