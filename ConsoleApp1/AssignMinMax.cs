using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AssignMinMax
    {
        static void Reassign(ref int a, ref int b)
        {
            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
        }
        static void Main()
        {
            Console.Write("Input int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input int b: ");
            int b = int.Parse(Console.ReadLine());

            Reassign(ref a, ref b);
            Console.WriteLine("new a = {0}, new b = {1}", a, b);
            
        }
    }
}
