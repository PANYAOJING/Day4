using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H1
    {
        static void Main()
        {
            int integer = ReadInteger();
            Console.WriteLine($"{integer}");
        }
        static int ReadInteger()
        {
            int integer = 0;
            bool is_integer = false;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ;
            while (!is_integer) { 
                Console.WriteLine("Pls enter an integer: ");
                is_integer = int.TryParse(Console.ReadLine(), out integer);
            }
            return integer;
        }
    }
}
