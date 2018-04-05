using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class TriangleB
    {
        static void Main()
        {
            string a = "*";
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("".PadLeft(80 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write(a);
                    
                }
                Console.WriteLine();
            }

        }
    }
}
