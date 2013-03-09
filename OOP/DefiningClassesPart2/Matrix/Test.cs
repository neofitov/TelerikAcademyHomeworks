using System;

namespace Matrix
{
    class Test
    {
        static void Main(string[] args)
        {
           
            Matrix<int> m1 = new Matrix<int>(2, 2);
            Matrix<double> m2 = new Matrix<double>(2, 2);
            Matrix<int> m3 = new Matrix<int>(2, 2);

            m1[0, 0] = 5;
            m1[0, 1] = 3;
            m1[1, 0] = 2;
            m1[1, 1] = 1;

            m2[0, 0] = 5.3;
            m2[0, 1] = 3.4;
            m2[1, 0] = 2.6;
            m2[1, 1] = 0;

            m3[0, 0] = 2;
            m3[0, 1] = 3;
            m3[1, 0] = 4;
            m3[1, 1] = 5;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            
            if (m1)
            {
                Console.WriteLine("The matrix m1 has zero elements");
            }
            else
            {
                Console.WriteLine("The matrix m1 doesn't have zero elements");
            }

            if (m2)
            {
                Console.WriteLine("The matrix m2 has zero elements");
            }
            else
            {
                Console.WriteLine("The matrix m2 doesn't have zero elements");
            }

            Console.WriteLine();

            Console.WriteLine("\nAddition:\n");
            Matrix<int> result = m1 + m3;
            Console.WriteLine(result);

            Console.WriteLine("Subtraction:\n");
            Matrix<int> difference = m1 - m3;
            Console.WriteLine(difference);

            Console.WriteLine("Multiplication:\n");
            Matrix<int> product = m1 * m3;
            Console.WriteLine(product);
        }
    }
}
