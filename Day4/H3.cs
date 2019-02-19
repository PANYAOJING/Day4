using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class H3
    {
        static void Main()
        {
            Console.WriteLine("Pls enter string1: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Pls enter string2: ");
            string s2 = Console.ReadLine();
            bool instr = InString(s1, s2);
            if (instr) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
        static bool InString(string s1, string s2)
        {
            bool instr = false;
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2[0] == s1[i])
                {
                    string s3 = s1.Substring(i, s2.Length);
                    if(s3 == s2)
                    { instr = true; }
                }
            }
            return instr;
        }
    }
}
