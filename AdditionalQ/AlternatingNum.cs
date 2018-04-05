using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class AlternatingNum
    {
        static void Main()
        {
            int a = 1, b = 20;
            while((b-a)>=1)
            {
                Console.Write(a+" ");
                Console.Write(b+" ");
                a++;
                b--;
            }
        
        }
    }
}
