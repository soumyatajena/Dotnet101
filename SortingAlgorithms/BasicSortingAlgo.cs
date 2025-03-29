using System;
using System.Collections.Concurrent;
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
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
            DisplaySortedArray(arr, "Selection");
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
                while (j >= 0 && arr[j] > key)
                {
                    // shift elemets to right until you reach the current ele correct position
                    arr[j + 1] = arr[j];
                    j--;
                }
                // store the current ele in its correct position
                arr[j + 1] = key;
            }
            DisplaySortedArray(arr, "Insertion");
        }
        #endregion
        #region Bubble Sort
        // STABLE SORTING ALGO
        // 1st iteration puts the largest ele at the array end and so on
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        // swap (using tuple)
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
            DisplaySortedArray(arr, "Bubble");
        }
        #endregion
        #region Quick Sort
        // Avg TC = O(nlogn), WC TC = O(n^2)
        // left items < Pivot < right items
        // Apply QS recursively on left half and right half

        public static int[] QuickSort(int[] arr, int st, int end)
        {
            if (st < end)
            {
                int pivot = Partition(arr, st, end);
                QuickSort(arr, st, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
            return arr;
        }
        private static int Partition(int[] arr, int st, int end)
        {
            int ind = st - 1; // ensures correct positioning of left side ele and pivot as well
            int p = arr[end];
            for (int j = st; j < end; j++)
            {
                if (arr[j]<=p)
                {
                    ind++;
                    (arr[j], arr[ind]) = (arr[ind], arr[j]);
                }
            }
            // place pivot at its correct position
            ind++;
            (arr[end], arr[ind]) = (arr[ind], arr[end]);
            return ind;
        }
        #endregion
        private static void DisplaySortedArray(int[] arr, string sortType)
        {
            Console.WriteLine($"Sorted Array using {sortType} Sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
