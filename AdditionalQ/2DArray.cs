using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class _2DArray
    {
        static void Main()
        {
            int[,] A = new int[5, 3] { {1,2,3},
                                       {3,4,5},
                                       {7,8,9},
                                       {8,7,2},
                                       {7,7,7}
                                      };

            MaxInROw(A);

        }

        static void MaxInROw(int[,] A)
        {
            int temp;
            for(int i = 0; i<5; i++)
            {
                temp = A[i, 0];
                for (int j =0; j<3; j++ )
                {

                    if (temp < A[i, j]) temp = A[i, j];
                }
                Console.WriteLine(temp);
            }
        }

        static void AvgRow(int[,] A)
        {

            for (int i = 0; i < 5; i++)
            {
                double sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum = sum + A[i, j];
                }

                Console.WriteLine("{0 : 0.##}", sum / 3);
            }
        }
    }
}
