using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //activity();
            //activity_01();
            activity_02();
            Console.ReadLine();
        }

        static void activity()
        {
            Console.WriteLine("Enter the First number - ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number - ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number - ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("output " + (x + y) * z );
            Console.WriteLine("output " + (x * y + y * z ));
            Console.ReadLine();
        }

        static void activity_01()
        {
            Console.WriteLine("Enter the your age - ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the your age" + age);
            Console.ReadLine();
        }

        static void activity_02()
        {
            Console.WriteLine("Enter a digit : ");
            String a =Console.ReadLine();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
                for(int k = 0; k < 4; k++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();

            }
            
           

            Console.ReadLine();
        }

        static void activity_03()
        {
            Console.WriteLine("Enter a number - ");
            String a = Console.ReadLine();

            Console.WriteLine(a + a + a);



        }
    }
}
