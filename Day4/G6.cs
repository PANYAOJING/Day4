using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G6
    {
        static void Main()
        {
            int[] array = { 1, 4, 7, 5, 3, 2, 5 };
            Console.Write("sort the array in ascending order: ");
            sort_in_ascending(array);
            Console.Write("sort the array in descending order: ");
            sort_in_descending(array);

        }
        static void sort_in_ascending(int [] array)
        {
            int size = array.Length;
            for(int i = 0; i < size - 1; i++)
            {
                for(int j = i; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            PrintArray(array);
        }
        static void sort_in_descending(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            PrintArray(array);
        }
        public static void PrintArray(int[] A)
        {
            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]}");
                if (i < A.Length - 1 && A[i] != 0)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }
    }
}
