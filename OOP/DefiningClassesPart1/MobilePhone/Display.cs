using System;
namespace MobilePhone
{
    class Display
    {
        //Fields and Properties - Start.
        private double size;
        public double Size
        {
            get { return size; }
            set
            {
                if (value > 0)
                {
                    size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private int numOfColors;
        public int NumOfColors
        {
            get { return numOfColors; }
            set
            {
                if (value > 0 && value % 2 == 0)
                {
                    numOfColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        //Fields and Properties - End.

        //Constructors - Start.
        public Display()
            : this(0.0, 0)
        {
        }

        public Display(double size)
            : this(size, 0)
        {
        }

        public Display(double size, int numOfColors)
        {
            this.size = size;
            this.numOfColors = numOfColors;
        }
        //Constructors - End.

        //Override ToString().
        public override string ToString()
        {
            return string.Format("\n\tScreen Size: {0}\n\tColors: {1}", size, numOfColors);
        }
    }
}
