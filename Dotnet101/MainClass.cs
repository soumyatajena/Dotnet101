using EasyInterviewProblems;
using LeetCodeProgram;
using SortingAlgorithms;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Dotnet101
{
    class MainClass
    {
        private static bool wantToContinue = true;

        public static void Main()
        {
            do
            {
                Console.WriteLine("Options available for you to choose:");
                Console.WriteLine("\n 1. Basic Interview Problems" +
                                  "\n 2. Leet Code Problems" +
                                  "\n 3. Sorting Algorithms");
                Console.WriteLine("Enter your option choice:");
                var outer = int.TryParse(Console.ReadLine(), out int num);
                if (outer)
                {
                    switch (num)
                    {
                        case 1:
                            BasicCode basicCode = new();
                            Console.WriteLine("You have several options to choose from, please select ONE : ");
                            Console.WriteLine("\n 1. String Manipulation \n 2. Palindrome \n 3. Fibonacci \n 4. Prime \n 5. 1D Array \n 6. 2D Array");
                            Console.WriteLine("Enter your option choice:");
                            var case1Inner = int.TryParse(Console.ReadLine(), out int case1NumInner);
                            switch (case1NumInner)
                            {
                                case 1:
                                    Console.WriteLine("Enter your choice of string :");
                                    var str1 = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(str1))
                                        basicCode.StringManipulation(str1);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter your choice of input for Palindrome check :");
                                    var str2 = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(str2))
                                    {
                                        bool response = basicCode.PalindromeCheck(str2);
                                        if (response) Console.WriteLine($"{str2} is a palindrome");
                                        else Console.WriteLine($"{str2} is not palindrome");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Enter how long you want your Fibonnaci series to be (n > 0):");
                                    var str3 = Console.ReadLine();
                                    _ = int.TryParse(str3, out int fib);
                                    if (fib >= 0)
                                    {
                                        int result = basicCode.Fibonacci(fib);
                                        Console.Write($"Recursive way - Fibonacci Series of {fib} => {result}");
                                        Console.WriteLine();
                                    }
                                    else Console.WriteLine("Please enter a correct positive integer > 0");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter a positive integer:");
                                    _ = int.TryParse(Console.ReadLine(), out int inpNum);
                                    if (inpNum > 0) basicCode.PrimeCheck(inpNum);
                                    else Console.WriteLine("Please enter a correct positive integer > 0");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter your array (DELIMITER : SPACE) :");
                                    string? inputLine = Console.ReadLine();
                                    if (inputLine != null)
                                    {
                                        string[] case5Arr = inputLine.Split(" ");
                                        basicCode.ArrManipulation(case5Arr);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Input cannot be null.");
                                    }
                                    break;
                                case 6:
                                    int[,] array2D = new int[2, 3];
                                    Console.WriteLine("Enter your 2D integer array:");
                                    for (int i = 0; i < 2; i++)
                                    {
                                        for (int j = 0; j < 3; j++)
                                        {
                                            Console.Write($"Enter element at position [{j},{i}]: ");
                                            array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                    basicCode.Arr2DManipulation(array2D);
                                    break;
                                default:
                                    Console.WriteLine("In future will try to add that number.");
                                    break;

                            }
                            break;
                        case 2:
                            LeetCodeEasy leetCodeEasy = new();
                            Console.WriteLine("You have several options to choose from, please select ONE : ");
                            Console.WriteLine("\n 1. Array Rotation \n 2. Duplicates Removal \n 3. Plus One \n 4. Move Zeroes \n 5. Sum betn 2 indices \n 6. Matrix rotation");
                            Console.WriteLine("Enter your option choice:");
                            var case2Inner = int.TryParse(Console.ReadLine(), out int case2NumInner);
                            switch (case2NumInner)
                            {
                                case 1:
                                    int[] nums1 = [2, 7, 11, 15];
                                    int k = 2;
                                    leetCodeEasy.Rotate(nums1, k);
                                    break;
                                case 2:
                                    int[] nums2 = [2, 7, 11, 15, 11];
                                    leetCodeEasy.RemoveDuplicates(nums2);
                                    bool res = leetCodeEasy.ContainsDuplicate(nums2) ? true : false;
                                    Console.WriteLine("Contains Duplicates : " + res);
                                    break;
                                case 3:
                                    int[] nums3 = [2, 7, 11, 15, 11];
                                    int[] newArr = leetCodeEasy.PlusOne(nums3);
                                    Console.WriteLine("Plus One with each number of array:");
                                    for (int i = 0; i < newArr.Length; i++)
                                    {
                                        Console.Write(newArr[i]);
                                    }
                                    break;
                                case 4:
                                    int[] nums4 = [2, 7, 0, 11, 15, 11, 0, 22];
                                    leetCodeEasy.MoveZeroes(nums4);
                                    break;
                                case 5:
                                    int target = 5;
                                    int[] nums5 = [2, 7, 11, 15, 11];
                                    Console.WriteLine($"The two indices sum which == the target - {target} is below:");
                                    int[] twoSum = leetCodeEasy.TwoSum(nums5, target);
                                    for (int i = 0; i < twoSum.Length; i++)
                                    {
                                        Console.Write(twoSum[i]);
                                    }
                                    break;
                                case 6:
                                    int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
                                    leetCodeEasy.RotateMatrix(matrix);
                                    break;
                                default:
                                    Console.WriteLine("In future will try to add that number.");
                                    break;
                            }
                            break;
                        case 3:
                            Random random = new();
                            int[] arr = new int[10];
                            for (int i = 0; i < arr.Length; i++)
                                arr[i] = random.Next(1, 100);
                            Console.WriteLine("\n Unsorted Array : ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();
                            BasicSortingAlgo basicSorting = new();
                            Console.WriteLine(" Two Options : ");
                            Console.WriteLine("\n 1. Basic Sorting Algorithms" +
                                              "\n 2. Advance Sorting Algorithms");
                            Console.WriteLine("Enter your option choice:");
                            var op = Convert.ToInt32(Console.ReadLine());
                            if (op == 1)
                            {
                                Console.WriteLine("Choose your choice of sorting algorithms : ");
                                Console.WriteLine("\n 1. Selection Sort \n 2. Insertion Sort \n 3. Bubble Sort \n 4. Merge Sort \n 5. Quick Sort");
                                Console.WriteLine("Enter your option choice:");
                                var case3Inner = int.TryParse(Console.ReadLine(), out int case3NumInner);
                                switch (case3NumInner)
                                {
                                    case 1:
                                        BasicSortingAlgo.SelectionSort(arr);
                                        break;
                                    case 2:
                                        BasicSortingAlgo.InsertionSort(arr);
                                        break;
                                    case 3:
                                        BasicSortingAlgo.BubbleSort(arr);
                                        break;
                                    case 4:                                        
                                        break;
                                    case 5:
                                        int[] sArr = BasicSortingAlgo.QuickSort(arr, 0, arr.Length - 1);
                                        Console.WriteLine("Sorted Array using Quick Sort: ");
                                        for (int i = 0; i < sArr.Length; i++)
                                        {
                                            Console.Write(sArr[i] + " ");
                                        }
                                        Console.WriteLine();
                                        break;
                                    case 6:
                                        break;
                                    default:
                                        Console.WriteLine("In future will try to add that number.");
                                        break;
                                }
                                break;
                            }
                            else if(op == 2)
                            {
                                Console.WriteLine("Choose your choice of sorting algorithms : ");
                                Console.WriteLine("\n 1. Heap Sort \n 2. Counting Sort \n 3. Radix Sort \n 4. Bucket Sort");
                                Console.WriteLine("Enter your option choice:");
                                var case3Inner = int.TryParse(Console.ReadLine(), out int case3NumInner);
                            }
                            else
                            {
                                Console.WriteLine("Please choose correct option. Try Again.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
                Console.Write("Do you wish to contine ? (Y/N) : ");
                wantToContinue = Console.ReadLine()?.Equals("y", StringComparison.CurrentCultureIgnoreCase) ?? false;
                Console.WriteLine();
            }
            while (wantToContinue);
        }

    }
}