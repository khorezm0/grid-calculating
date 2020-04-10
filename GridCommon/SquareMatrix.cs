using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    [System.Serializable]
    public class SquareMatrix
    {
        readonly int[][] matrix;
        readonly long size;
        public long Size => size;

        public SquareMatrix(long n)
        {
            matrix = new int[n][];
            for (int i = 0; i < n; i++) matrix[i] = new int[n];
            size = n;
        }

        public SquareMatrix(int[][] data)
        {
            if (data.Length > 0 && data.GetLongLength(0) != data[0].GetLongLength(0)) 
                throw new ArgumentException();

            matrix = data;
            size = data.GetLongLength(0);
        }

        public int this[int i, int j]
        {
            get { return matrix[i][j]; }
            set { matrix[i][j] = value; }
        }

        public int Sum(Bounds b)
        {
            if (b == null)
                throw new ArgumentNullException();

            if (b.StartLeft < 0L || b.StartLeft >= size
                || b.StartTop < 0L || b.StartTop >= size
                || b.EndLeft < 0L || b.EndLeft >= size
                || b.EndTop < 0L || b.EndTop >= size
                || b.StartLeft > b.EndLeft 
                || b.StartTop > b.EndTop
                )
                throw new ArgumentOutOfRangeException();

            int a = 0;
            for (long i = b.StartLeft; i < b.EndLeft; i++)
                for (long j = b.StartTop; j < b.EndTop; j++)
                {
                    a += matrix[i][j];
                }

            return a;
        }

        public int Sum() 
        {
            int a = 0;
            for (long i = 0; i < size; i++)
                for (long j = 0; j < size; j++)
                {
                    a += matrix[i][j];
                }

            return a;
        }
    }
}
