using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class TriangleMethod
    {
        static void Triangle1(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                { Console.Write("*"); }
                Console.WriteLine();
            }
        }

        static void Triangle2(int x)
        {
            string a = "*";
            for (int i = 1; i <= x; i++)
            {
                Console.Write("".PadLeft(80 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write(a);

                }
                Console.WriteLine();
            }
        }

        static void Triangle3(int x)
        {
            string a = "*";
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(a.PadLeft(Console.WindowWidth / 2 + a.Length / 2));
                //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));

                a = a + '*';

            }
        }

        static void Triangle4(int x)
        {
            string a = "";
            for(int k=0;k<x;k++)
            {
                a = a + '*';
            }

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(a.PadLeft(Console.WindowWidth / 2 + a.Length / 2));
                //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));

                a = a.Substring(0, a.Length - 1);

            }
        }

        static void Main()
        {
            int a, b;
            Console.WriteLine("What Triangle would you like to create? From type 1-4: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Intended height of the triangle: ");
            b = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Triangle1(b); break;

                case 2:
                    Triangle2(b); break;

                case 3:
                    Triangle3(b); break;

                case 4:
                   Triangle4(b); break;


            }
        }
    }
}
