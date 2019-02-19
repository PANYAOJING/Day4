using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H6
    {
        static void Main()
        {
            Console.WriteLine("Pls enter a string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Pls enter character1: ");
            char a = Char.Parse(Console.ReadLine());
            Console.WriteLine("Pls enter character2: ");
            char b = Char.Parse(Console.ReadLine());
            string s = Substitute(s1,a,b);
            Console.WriteLine(s);
        }
        static string Substitute(string s, char c1, char c2)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (c1 == s[i])
                {
                    s = s.Substring(0, i) + c2 + s.Substring(i + 1);
                }
            }
            return s;
        }
    }
}
