using System.Collections.Generic;

namespace _3DPoint
{
    class Path
    {
        public readonly List<Point3D> sequence = new List<Point3D>();

        public List<Point3D> Sequence
        {
            get
            {
                return this.sequence;
            }
        }

        public void AddPoint(Point3D point)
        {
            sequence.Add(point);
        }

        public void ClearSequence()
        {
            sequence.Clear();
        }
    }
}
