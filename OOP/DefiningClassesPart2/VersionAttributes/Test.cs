using System;

namespace VersionAttributes
{
    [VersionAttribute(2, 11)]
    class Test
    {
        static void Main(string[] args)
        {
            try
            {
                Type type = typeof(Test);
                object[] allAttributes = type.GetCustomAttributes(false);
                foreach (VersionAttribute versionAttribute in allAttributes)
                {
                    Console.WriteLine("Version: {0} ", versionAttribute);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Version Attribute!");
            }
        }
    }
}
