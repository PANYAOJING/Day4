using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class G1
    {
        static string[] month = { "", "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
        static void Main()
        {
            int[] sales = new int[12];
            double sum = 0.0;
            int max = 0;
            int[] max_m = new int[12];
            int min = 0;
            int[] min_m = new int[12];
            Console.WriteLine("Pls enter the monthly sales in order: ");
            for(int i = 0; i < 12; i++)
            {
                bool b;
                int res;
                b=int.TryParse(Console.ReadLine(),out res);
                //sales[i] = int.Parse(Console.ReadLine());
                if( b) { sales[i] = res; }
                sum += sales[i];
            }
            min = sales[0];
            for (int i = 0; i < 12; i++)
            {
                if (max < sales[i]) {
                    max = sales[i];
                }
                if (min > sales[i])
                {
                    min = sales[i];
                }
            }
            int num_max = 0;
            int num_min = 0;
            for(int i = 0; i < 12; i++)
            {
                if (sales[i] == max)
                {
                    max_m[num_max] = i+1;
                    num_max++;
                }
                if (sales[i] == min)
                {
                    min_m[num_min] = i+1;
                    num_min++;
                }
            }
           
            Console.WriteLine("The month when Maximum Sales: ");
            PrintArray(max_m);
            Console.WriteLine("The month where Minimum Sales: ");
            PrintArray(min_m);
            Console.WriteLine($"The average monthly sales for the year: {sum/12}");
        }
        public static void PrintArray(int[] A)
        {
            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{month[A[i]]}");
                if (i < A.Length - 1 && A[i] != 0)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }
    }
}
