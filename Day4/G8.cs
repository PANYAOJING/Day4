using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G8
    {
        static void Main()
        {
            int[,] array =
            {
                {1,2,3,4,5 },
                {2,3,4,5,6 },
                {3,4,5,6,7 },
                {4,5,6,7,8 }
            };
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for(int row = 0; row < array.GetLength(0); row++)
            {
                for(int col = 0; col < array.GetLength(1); col++)
                {
                    if (array[row, col] == number)
                    {
                        Console.WriteLine($"Number {number} is found in the array at [{row},{col}]");
                    }
                }
            }
        }
    }
}
