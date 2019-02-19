using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Bank of ISS\n");
            Console.Write("Enter your PIN: ");
            string p1 = Console.ReadLine();
            string p2 = "123456";
            int times = 1;

            while (p1 != p2 && times < 3)
            {
                Console.Write("Incorrect PIN. Please try again\n");
                Console.Write("Enter your PIN: ");
                p1 = Console.ReadLine();
                times++;
            }

            if ( p1 == p2)
            {
                Console.Write("PIN accepted. You can access your account now.");
            }
            else
            {
                Console.Write("Too many wrong PIN entries. Your account is now locked.");
            }
        }
    }
}
