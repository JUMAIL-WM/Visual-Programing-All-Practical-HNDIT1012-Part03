using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            jumail();
        }
        static void jumail()
        {
           /* Console.WriteLine("Enter the number");
            int N = int.Parse(Console.ReadLine());

            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a + "*" + N + "=" + N * a);
                a++;
            }
            Console.ReadLine();*/

            for (int i = 1; i <= 12; i=i+2)
            {
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
