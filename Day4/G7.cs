using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G7
    {
        static void Main()
        {
            string[] names = { "Bob", "Charlie", "Gina", "Frank", "Eli", "Dennis", "Alice" };
            int[] marks = { 90, 120, 88, 66, 76, 80, 100 };
            int mark;
            string name;

            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i; j < marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        mark = marks[i];
                        marks[i] = marks[j];
                        marks[j] = mark;
                        name = names[i];
                        names[i] = names[j];
                        names[j] = name;
                    }
                }
            }
            Console.WriteLine("Name\t Score");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t {marks[i]}");
            }
        }
    }
}
