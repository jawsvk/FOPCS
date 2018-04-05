using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class TriangleA
    {
        static void Main()
        {
            for(int i=1;i<=6;i++)
            {
                for(int j=0;j<i;j++)
                { Console.Write("*"); }
                Console.WriteLine();
            }
        }
    }
}
