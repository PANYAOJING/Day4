using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H2
    {
        static void Main()
        {
            int[] array = { 2, 3, 5, 6, 7 };
            Printarray(array);
        }
        static void Printarray(int[] arr)
        {
            Console.Write("{");
            for(int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1) 
                    Console.Write($"{arr[i]},");
                else
                    Console.Write($"{arr[i]}");
            }
            Console.Write("}");
        }
    }
}
