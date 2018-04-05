using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class FibonacciNum
    {
        static void Main()
        {
            int sum1 = 0, sum2 = 1;
            
            for(int i =0; i<12; i++)
            {
                Console.Write(sum1 + " ");
                int temp = sum1;
                sum1 = sum2;
                sum2 = sum2 + temp;
            }
            
        }
    }
}
