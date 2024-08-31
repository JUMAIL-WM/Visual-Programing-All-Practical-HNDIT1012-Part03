using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace project_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forloops();
            Console.WriteLine("Hello");
            whileloop();
            Console.ReadLine();

        }

        static void whileloop()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            do
            {
                factorial *= n;
                n--; //decrement operator//
            } while(n > 0);
            Console.WriteLine("n! =" + factorial);
        }

        static void forloops()
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for(int i = n; i > 0; i--) //i=5 ; 5>0 ;5--
            {

                factorial *= i; //f=f*1 
            }
            Console.WriteLine("n! =" + factorial);
        }
    }
}
