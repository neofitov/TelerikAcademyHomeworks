using System;
using System.Collections.Generic;

namespace _3DPoint
{
    class Test
    {
        static void Main()
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(4, 5, 6);
            
            Console.WriteLine("1: " + p1);
            Console.WriteLine("2: " + p2);
            Console.WriteLine("Distance: " + Distance.CalcDistance(p1, p2));
           
            Console.WriteLine("Zero Point:");
            Console.WriteLine(Point3D.zero);

            Path pathSequence = new Path();
            pathSequence.AddPoint(p2);
            pathSequence.AddPoint(p1);
            pathSequence.AddPoint(p2);

            PathStorage.SavePath(pathSequence);
            List<Path> pathList = PathStorage.LoadPath();
            foreach (var path in pathList)
            {
                Console.WriteLine("-----Path Start-------");
                foreach (var p in path.Sequence)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("-----Path End-------");

            }

            Console.WriteLine("Path Sequence: ");
            foreach (var item in pathSequence.sequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
