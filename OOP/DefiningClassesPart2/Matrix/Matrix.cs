using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix<T> where T : IComparable
    {
        // fields
        public readonly int x;
        public readonly int y;
        private T[,] matrix;

        // constructor
        public Matrix(int x, int y)
        {
            this.y = x;
            this.x = y;
            matrix = new T[x, y];
        }

        // indexing
        public T this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }

            set
            {
                matrix[x, y] = value;
            }
        }

        // overload +
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> sum = new Matrix<T>(m1.x, m1.y);

            if (m1.y == m2.y && m1.x == m2.x)
            {
                for (int i = 0; i < m1.x; i++)
                {
                    for (int j = 0; j < m1.x; j++)
                    {
                        dynamic tmp1 = m1[i, j];
                        dynamic tmp2 = m2[i, j];
                        sum[i, j] = tmp1 + tmp2;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Operator '+' can only be applied to matrixes with same sizes!");
            }

            return sum;
        }

        // overload -
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> sum = new Matrix<T>(m1.x, m1.y);

            if (m1.y == m2.y && m1.x == m2.x)
            {
                for (int i = 0; i < m1.x; i++)
                {
                    for (int j = 0; j < m1.x; j++)
                    {
                        dynamic tmp1 = m1[i, j];
                        dynamic tmp2 = m2[i, j];
                        sum[i, j] = tmp1 - tmp2;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Operator '-' can only be applied to matrixes with same sizes!");
            }

            return sum;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.x, m1.y);
            for (int i = 0; i < result.x; i++)
            {
                for (int j = 0; j < result.y; j++)
                {
                    for (int k = 0; k < m1.y; k++)
                    {
                        for (int l = 0; l < m1.y; l++)
                        {
                            dynamic tmp1 = m1[i, j];
                            dynamic tmp2 = m2[i, j];
                            result[i, j] += tmp1 * tmp2;
                        }
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> m1)
        {

            bool isNull = false;

            for (int i = 0; i < m1.x; i++)
            {
                for (int j = 0; j < m1.x; j++)
                {
                    dynamic tmp1 = m1[i, j];

                    if (tmp1 == 0)
                    {
                        isNull = true;
                    }
                }
            }

            return isNull;
        }

        public static bool operator false(Matrix<T> m1)
        {

            bool isNull = true;

            for (int i = 0; i < m1.x; i++)
            {
                for (int j = 0; j < m1.x; j++)
                {
                    dynamic tmp1 = m1[i, j];

                    if (tmp1 == 0)
                    {
                        isNull = false;
                    }
                }
            }

            return isNull;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.x; i++)
            {
                for (int j = 0; j < this.y; j++)
                {
                    result.AppendFormat("{0, 5}", this[i, j]);
                }
                result.AppendLine("");
            }
            return result.ToString();
        }
    }
}
