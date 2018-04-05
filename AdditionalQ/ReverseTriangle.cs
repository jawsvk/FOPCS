using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class ReverseTriangle
    {
        static void Main()
        {
            string a = "******";
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(a.PadLeft(Console.WindowWidth / 2 + a.Length / 2));
                //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));

                a = a.Substring(0,a.Length-1);

            }
        }
    }
}
