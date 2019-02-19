using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G5
   {
        static void Main()
        {
            int[] array = { 1, 4, 7, 5, 3, 2, 5 };

            Console.Write("Pls enter the num: ");
            int num = int.Parse(Console.ReadLine());
            int index_1 = Array.IndexOf(array,num);
            int[] index_2 = new int[array.Length];
            int index_of_index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == num)
                {
                    index_2[index_of_index] = i;
                    index_of_index++;

                    Console.Write($"{i}\t");
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"{index_1}");
        }
    }
}
