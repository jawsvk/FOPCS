using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalQ
{
    class ArraySearchSort
    {
        static void Main()
        {
            int[] A = new int[] { 3, 5, 4, 12, 8 };
            DescendingSort(A);
           
            Console.WriteLine(BinarySearch(A, 8));
        }

        static void DescendingSort(int[] A)
        {
            int temp;
            for (int i = 0; i < A.Length; i++)
            {
               // temp = A[i];
                for(int j =i; j<A.Length;j++)
                {
                    temp = A[i];
                    if (temp<A[j])
                    {
                        temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }

                }

            }
            PrintArray(A);

        }

        static void PrintArray(int[] A)
        {
            for(int i =0; i<A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();

        }
        
        static void Search(int[] A)
        {
            int i, num;
            //search for num
            Console.Write("Number to search: ");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i < A.Length; i++)
            {
                if (A[i] == num) Console.WriteLine(i);

            }
            if (i == A.Length)
            {
                Console.WriteLine("number cannot be found");
            }
        }

        public static int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return inputArray.Length;
        }
    }

}
