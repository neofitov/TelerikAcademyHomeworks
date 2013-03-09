using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        public static void GSMCallHistoryTestMethod()
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("        Call History Test!");
            Console.WriteLine("------------------------------------\n");
            
            GSM phone = new GSM("Galaxy S 3", "Samsung");

            phone.AddCall(new Call(DateTime.Parse("6/12/2009 07:23:00 AM"), "0888123456") { Duration = 31 });
            phone.AddCall(new Call(DateTime.Parse("10/11/2010 10:44:00 AM"), "0888678910") { Duration = 360 });
            phone.AddCall(new Call(DateTime.Parse("7/05/2012 06:56:00 PM"), "0888111213") { Duration = 600 });

            PrintCalls(phone);

            //Get longest call.
            var maxCall =
                (from call in phone.CallHistory
                 orderby call.Duration descending
                 select call).First();

            //Delete longest call.
            phone.DeleteCall(phone.CallHistory.IndexOf(maxCall));

            PrintCalls(phone);

            //Clear all calls.
            phone.ClearHistory();

            PrintCalls(phone);
        }

        //Print calls and price.
        static void PrintCalls(GSM phone)
        {
            List<Call> callHistory = phone.CallHistory;
            if (callHistory != null)
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine();
                    Console.Write("-------Call Start--------");
                    Console.WriteLine(call);
                    Console.WriteLine("-------Call End--------");
                }

                Console.Write("\nTotal Price: ");
                Console.WriteLine(phone.CalculatePrice(0.37m));
            }
            else
            {
                Console.WriteLine("\nEmpty CallHistory!");
            }
        }
    }
}
