using System;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] phones = new GSM[4];

            phones[0] = new GSM("BlackBerry", "BlackBerry", 300, "Gosho", 
                new Battery("7V900S", 44.4, 8.3, BatteryType.LiIon), new Display(4, 16000));
            
            phones[1] = new GSM("Iphone 5", "Apple", 1000, "Misho", 
                new Battery("7V901S", 66.3, 10.3, BatteryType.NiCd), new Display(8, 65000));
            
            phones[2] = new GSM("Xperia Tipo", "Sony", 150, "Pesho", 
                new Battery("7V902S", 33.1, 5.3, BatteryType.NiMH), new Display(5, 16000));
            
            phones[3] = new GSM("Galaxy S 3", "Samsung", 1100, "Ceko", 
                new Battery("7V903S", 80.5, 15.5), new Display(9, 65000));

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(phones[i]);
            }

            //This is the static property!
            Console.WriteLine("\nStatic property:\n\n{0}", GSM.Iphone4S);

            //Call History Test!
            GSMCallHistoryTest.GSMCallHistoryTestMethod();
        }
    }
}
