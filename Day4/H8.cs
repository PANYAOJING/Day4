using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H8
    {
        static void Main()
        {
            Console.Write("Pls enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.Write("Pls enter the value of array:");
            int value = int.Parse(Console.ReadLine());
            SetArray(ref arr, value);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            Console.Write("Pls enter the  new size of array:");
            int newsize = int.Parse(Console.ReadLine());
            int[] result = ResizeArray(arr, newsize);
            for (int i = 0; i < newsize; i++)
            {
                Console.Write($"{result[i]}\t");
            }
        }
        static void SetArray(ref int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }
        static int[] ResizeArray(int[] arr, int newSize)
        { 
            int[] result = new int [newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }
            return result;
        }
    }
}
