using System;

namespace VersionAttributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    class VersionAttribute : System.Attribute
    {

        // fields
        private int major;
        private int minor;

        // properties
        public int Major
        {
            get
            {
                return this.major;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.minor = value;
            }
        }

        // constructor
        public VersionAttribute(int maj, int min)
        {
            this.Major = maj;
            this.Minor = min;
        }

        // override ToString()
        public override string ToString()
        {
            return String.Format("{0}.{1}", Major, Minor);
        }
    }
}
