using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ResizeArray
    {
        static int[] Resize(int[] A, int x)
        {
            int a = A.Length;
            int[] newA = new int[x];
            CopyContent(A, newA);
            return newA;
        }

        static void CopyContent(int[] Arr, int[] newArr)
        {
            int a = Arr.Length;
            int b = newArr.Length;

            for(int i =0; i<Math.Min(a,b); i++)
            {
                newArr[i] = Arr[i];

            }
        }

        static void PrintArray(int[] A)
        {
            for(int i=0; i<A.Length; i++)
            {
                if (i == A.Length - 1) Console.Write(A[i]+" \n");
                else
                {
                    Console.Write(A[i] + ", ");
                }
            }
        }
        static void Main()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Console.Write("New size of array: ");
            int x = int.Parse(Console.ReadLine());
            array = Resize(array, x);
            PrintArray(array);
        }
    }
}
