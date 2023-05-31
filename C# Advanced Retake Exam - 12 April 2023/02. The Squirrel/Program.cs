using System;

namespace _02._The_Squirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            Solution solution = new Solution();
            Console.WriteLine(string.Join(' ', solution.TwoSum(nums, 9)));
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //Input: nums = [2,7,11,15], target = 9
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            //Output: [0,1]
            //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
            throw new Exception("Not found.");
        }
    }
}
