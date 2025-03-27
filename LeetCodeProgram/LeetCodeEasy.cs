using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProgram
{
    public class LeetCodeEasy
    {
        public int RemoveDuplicates(int[] nums)
        {
            int[] tempArr = nums;
            int k = 1;
            int prev = tempArr[0];
            nums[0] = tempArr[0];
            for (int i = 1; i < tempArr.Length; i++)
            {
                if (prev != tempArr[i])
                {
                    nums[k] = tempArr[i];
                    prev = tempArr[i];
                    k++;
                }
            }
            return k;
        }
        public void Rotate(int[] nums, int k)
        {
            int[] tempArr = nums.ToArray();
            int len = nums.Length;
            if (k > len) k %= len;
            int counter = 0;
            int counter1 = len - k;
            for (int i = 0; i < len; i++)
            {
                if (i < k) nums[i] = nums[counter1++];
                else nums[i] = tempArr[counter++];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

            // OR

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, len - k);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
        }
        public bool ContainsDuplicate(int[] nums)
        {
            int[] uniqueArr = nums.ToArray();
            uniqueArr = nums.Distinct().ToArray();
            if (uniqueArr.Length == nums.Length) return false;
            else return true;
        }
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.Keys.Contains(nums[i])) dict[nums[i]]++;
                else dict.Add(nums[i], 1);
            }
            return dict.FirstOrDefault(d => d.Value == 1).Key;

            //int ans = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    ans ^= nums[i];
            //}

            //return ans;
        }
        public int[] PlusOne(int[] digits)
        {
            long plusOne = Convert.ToInt64(string.Join("", digits)) + 1;
            List<int> newArr = new();
            while (plusOne > 0)
            {
                int i = (int)plusOne % 10;
                newArr.Add(i);
                plusOne /= 10;
            }
            newArr.Reverse();
            return newArr.ToArray();
        }
        public void MoveZeroes(int[] nums)
        {
            List<int> list = new();
            list = nums.ToList().FindAll(a => a != 0);
            int zeroCount = nums.Length - list.Count;
            for (int i = 0; i < zeroCount; i++)
            {
                list.Add(0);
            }
            nums = list.ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);

            }
        }
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = nums[i] - target;
                if (dict.ContainsKey(complement))
                    return [dict[complement], i];
                dict[nums[i]] = i;
            }
            return [];
        }
        public void RotateMatrix(int[][] matrix)
        {
            // Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
            // Output: [[7,4,1],[8,5,2],[9,6,3]] 
            int rcount = 0;
            int len = matrix.Length;
            int[,] temp = new int[len, 1];
            for (int c = 0; c < len; c++)
            {
                rcount = len - 1;
                for (int r = 0; r < len; r++)
                {
                    if (c == 0)
                    {
                        // Transpose and reverse the col to row
                        temp[r, 0] = matrix[r][c + 1];
                        matrix[c][rcount--] = matrix[r][c];
                    }
                    if (c > 0 && c < len)//2
                    {
                        matrix[c][rcount--] = temp[r, 0];
                        if (c < len - 1)
                        {
                            temp[r, 0] = matrix[r][c + 1];
                        }
                    }
                }
            }

        }
    }
}
