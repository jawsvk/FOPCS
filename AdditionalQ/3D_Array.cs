using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class _3D_Array
    {
        static void Main()
        {
            int[,,] A = new int[3, 3, 3]{
                                     {{1,2,3},{3,4,5},{4,5,6}},
                                     {{10,5,0},{10,9,8},{10,4,4}},
                                     {{ 5,5,5},{0,9,9},{9,9,9}}
                                        };

            for (int i=0; i< A.GetLength(0); i++)
            {
                for(int j=0; j< A.GetLength(1); j++)
                {
                  int  temp = 0;
                    for (int k=0;  k < A.GetLength(2); k++)
                    {
                       // Console.Write(A[i, j, k] + "\t");
                       temp = temp + A[i, j, k];
                    }
                    Console.Write("{0}\t", temp/A.GetLength(2));
                   // Console.WriteLine();
                }
                Console.WriteLine();

            }


        }
    }


}
