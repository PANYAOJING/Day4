using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H5
    {
        static void Main()
        {
            string result;
            Console.WriteLine("Pls enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            result = get_hex(num);
            Console.WriteLine(result);
        }
        static string get_hex(int num)
        {
            string result = "";
            char[] hex_ch = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            while (num > 15)
            {
                result = hex_ch[num % 16] + result;
                num = num / 16;
            }
            result = hex_ch[num % 16] + result;
            return result;
        }
    }
}
