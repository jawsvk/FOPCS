using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class Q8
    {
        static void Main()
        {
            int a = 1;
            for(int i = 1; i<6; i++)
            {
                for(int j = 1; j<=i; j++ )
                {
                    Console.Write("{0} ", a);
                    a++;
                }
                Console.WriteLine();
            }
        }
    }
}
