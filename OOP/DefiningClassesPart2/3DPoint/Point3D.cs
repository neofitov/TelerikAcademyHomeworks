namespace _3DPoint
{
    public struct Point3D
    {
        // fields
        private double x;
        private double y;
        private double z;
        static public readonly Point3D zero = new Point3D(0, 0, 0);

        // properties
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D Zero
        {
            get { return zero; }
        }

        // constructor
        public Point3D(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // override ToString()
        public override string ToString()
        {
            return string.Format("Point: ({0}, {1}, {2})\n", x, y, z);
        }
    }
}
