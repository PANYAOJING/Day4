using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G4
    {
        static void Main()
        {
            Console.WriteLine("Pls enter the size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(100);
                System.Threading.Thread.Sleep(100);
            }
            Array.Sort(array);
            PrintArray(array);
        }
        static void PrintArray(int[] array)
        {
            Console.Write("[");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{ array[i]},");
            }
            Console.WriteLine("]");
        }
    }
}
