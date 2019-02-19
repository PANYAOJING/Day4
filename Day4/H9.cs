using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H9
    {
        static void Main()
        {
            
            for (int x = 5; x <= 1000; x++)
            {
                if (isPrimeNum(x)) { Console.Write($"{x}\t"); }
            }
        }
        static bool isPrimeNum(int n)
        {
            bool prime = true;
            int factor = 2;
            while (factor < n && prime)
            {
                if (n % factor == 0) { prime = false; }
                factor++;
            }
            return prime;
        }
    }
}
