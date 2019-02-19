using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G3
    {
        static void Main()
        {
            double[,] stu_marks = new double[,]{ { 56,84,68,29},
                                                {94,73,31,96 },
                                                {41,63,36,90 },
                                                {99,9,18,17 },
                                                {62,3,65,75 },
                                                {40,96,53,23 },
                                                {81,15,27,30 },
                                                {21,70,100,22 },
                                                {88,50,13,12 },
                                                {48,54,52,78 },
                                                {64,71,67,25 },
                                                {16,93,46,72 } };
            gettotalmarksofeachstu(stu_marks);
        }
        static void gettotalmarksofeachstu(double[,] array)
        {
            int num_stus = array.GetLength(0);
            int num_sub = array.GetLength(1);
            double[] totalmarksofeachstu = new double[num_stus];
            double[] avgmarksofeachstu = new double[num_stus];
            double[] avgmarksofeachsub = new double[num_sub];
            double[] totalmarksofeachsub = new double[num_stus];
            double[] variance = new double[num_sub];
            for (int row = 0; row < num_stus; row++)
            {
                double sum = 0;
                for(int col = 0; col < num_sub; col++)
                {
                    sum += array[row,col];
                }
                totalmarksofeachstu[row] = sum;
                avgmarksofeachstu[row] = sum / num_sub;
            }
            for (int col = 0; col < num_sub; col++)
            {
                double sum = 0;
                double[] temp = new double[num_stus];
                for (int row = 0; row < num_stus; row++)
                {
                    sum += array[row, col];
                    temp[row] = array[row, col];
                }
                totalmarksofeachsub[col] = sum;
                avgmarksofeachsub[col] = sum / num_stus;
                variance[col] = getvariance(temp, avgmarksofeachsub[col]);
            }
            Console.WriteLine("Total marks of each student: ");
            PrintArray(totalmarksofeachstu);

            Console.WriteLine("Average mark of each student: ");
            PrintArray(avgmarksofeachstu);

            Console.WriteLine("Average marks of each subject: ");
            PrintArray(avgmarksofeachsub);

            Console.WriteLine("Variance: ");
            PrintArray(variance);
        }
        public static void PrintArray(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]}");
                if (i < A.Length - 1 && A[i] != 0)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
        static double getvariance(double[] sub, double avg)
        {
            double sum = 0;
            for(int i = 0; i < sub.Length; i++)
            {
                sum += Math.Pow(sub[i] - avg, 2);
            }
            return Math.Sqrt(sum / sub.Length);
        }
    }
}
