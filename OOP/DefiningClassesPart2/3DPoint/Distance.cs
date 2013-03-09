using System;

namespace _3DPoint
{
    using System;

    public static class Distance
    {
        public static double CalcDistance(Point3D p1, Point3D p2)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            double dz = p1.Z - p2.Z;

            double d = (double) Math.Sqrt(dx * dx + dy * dy + dz * dz);
            return d;
        }
    }
}
