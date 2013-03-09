using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Test
    {
        static void Main()
        {
            GenericList<int> l = new GenericList<int>(1);
            
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(-1);

            Console.WriteLine(l);

            l.RemoveAt(5);

            Console.WriteLine(l);

            l.InsertAt(0, -3);

            Console.WriteLine(l);

            Console.WriteLine(l.IndexOf(-3));


            Console.WriteLine(l.Max());
            Console.WriteLine(l.Min());

            l.Clear();

            Console.WriteLine(l);
        }
    }
}
