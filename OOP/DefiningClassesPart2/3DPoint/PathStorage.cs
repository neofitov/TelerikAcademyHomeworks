using System;
using System.Collections.Generic;
using System.IO;

namespace _3DPoint
{
    class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../SavePath.txt"))
            {
                foreach (var point in path.Sequence)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static List<Path> LoadPath()
        {
            Path path = new Path();
            List<Path> pathList = new List<Path>();
            
            using (StreamReader reader = new StreamReader(@"../../LoadPath.txt"))
            {
                string line = reader.ReadLine();
                
                while (line != null)
                {
                    if (line != "END OF PATH")
                    {
                        Point3D point = new Point3D();
                        string[] coordinates = line.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                        point.X = int.Parse(coordinates[0]);
                        point.Y = int.Parse(coordinates[1]);
                        point.Z = int.Parse(coordinates[2]);
                        path.AddPoint(point);
                    }
                    else
                    {
                        pathList.Add(path);
                        path = new Path();
                    }
                    line = reader.ReadLine();
                }
            }
            return pathList;
        }
    }
}
