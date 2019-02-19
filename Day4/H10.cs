using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H10
    {
        static void Main()
        {
            int[,] A =
            {
                {1,2,3,0 },
                {1,1,1,0 },
                {2,2,2,1 }
            };
            int[,] B =
            {
                {1,2,3 },
                {1,0,1 },
                {2,0,2 },
                {1,1,2 }
            };
            int[,] result = MatrixMultiply(A, B);
            printmatrix(result);
        }
        static int[,] MatrixMultiply(int[,] A,int[,] B)
        {
            int[,] result = new int[A.GetLength(0), B.GetLength(1)];
            for(int row_a = 0; row_a < A.GetLength(0); row_a++)
            {
                for(int col_b = 0; col_b < B.GetLength(1); col_b++)
                {
                    for(int k = 0; k < A.GetLength(1); k++)
                    {
                        result[row_a, col_b] += A[row_a, k] * B[k, col_b];
                    }
                }
            }
            return result;
        }
        static void printmatrix(int[,] matrix)
        {
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
