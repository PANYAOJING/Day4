using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G2
    {
        static void Main()
        {
            int[] array = { 9, 4, 6, 3, 5, 8, 3 };
            Console.Write("Original arry: ");
            PrintArray(array);
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i; j < array.Length;j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        PrintArray(array);
                    }
                }
            }
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
