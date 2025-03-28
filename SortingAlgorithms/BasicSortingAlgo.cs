using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BasicSortingAlgo
    {
        /***
             * STABLE SORTING ALGO - PRESERVE THE RELATIVE POSITIONS AS INSERTED IN ARRAY
             * [AA,CC,BZ,DD,BM] = > [AA,BZ,BM,CC,DD]
             * UNSTABLE SORTING ALGO - POSITIONS WILL BE REPLACED
             * [AA,CC,BZ,DD,BM] = > [AA,BM,BZ,CC,DD]
             */

        #region Selection Sort
        // UNSTABLE SORTING ALGO
        public static void SelectionSort(int[] arr)
        {
            for (int i=0;i<arr.Length-1;i++)
            {
                int min = i;
                for (int j=i+1;j<arr.Length;j++)
                {        
                    // find the smallest ele in array , switch its position at arr[0] and so on
                    if (arr[j] < arr[min])
                        min = j;
                }
                // Swap ele to correct positions
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            Console.WriteLine("Sorted Array using Selection Sort: ");
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Insertion Sort
        // STABLE SORTING ALGO
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i]; // save the current ele
                int j = i - 1; // last ele position of sorted array
                while(j>=0 && arr[j]> key)
                {
                    // shift elemets to right until you reach the current ele correct position
                    arr[j + 1] = arr[j];
                    j--;
                }
                // store the current ele in its correct position
                arr[j + 1] = key;
            }

            Console.WriteLine("Sorted Array using Insertion Sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
