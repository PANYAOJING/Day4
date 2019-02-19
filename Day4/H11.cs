using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H11
    {
        static void Main()
        {
            double[] arr = { 1, 2, 3};
            double[] res1 = { 1, 2, 3 };
            double[] res2 = new double[3];
            //DO SQUAREROOT
            DoubleOps myOp1 = delegate (double b)
            {
                return Math.Sqrt(b);
            };
            res1 = ProcessArray(arr, myOp1);
            Console.WriteLine("SquareRoot:");
            for(int i = 0; i < res1.Length; i++)
            {
                Console.Write($"{res1[i]}\t\t");
            }
            // DO SQUARE
            DoubleOps myOp2 = delegate (double c)
            {
                return Math.Pow(c,2);
            };
            Console.WriteLine();
            res2 = ProcessArray(arr, myOp2);
            Console.WriteLine("Square:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{res2[i]}\t\t");
            }
        }
        delegate double DoubleOps(double n);
        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] result = new double[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                result[i] = ops(arr[i]);
            }
            return result;
        }
    }
}
