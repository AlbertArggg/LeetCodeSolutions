using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Task:
 *  Given an array of integers nums and an integer target, return indices of the two numbers such that 
 *  they add up to target. You may assume that each input would have exactly one solution, and you may 
 *  not use the same element twice. You can return the answer in any order.
 *  
 *  Input: nums = [2,7,11,15], target = 9
 *  Output: [0,1]
 *  
 *  Input: nums = [3,2,4], target = 6
 *  Output: [1,2]
 *  
 *  Input: nums = [3,3], target = 6
 *  Output: [0,1]
 *  
 *  Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
 */

class Program
{
    static void Main(string[] args)
    {
        // Example 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;

        Console.WriteLine("V1: " + PrintResults(TwoSum_V1(nums1, target1), target1));
        Console.WriteLine("V2: " + PrintResults(TwoSum_V1(nums1, target1), target1));

        // Example 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;

        Console.WriteLine("V1: " + PrintResults(TwoSum_V1(nums2, target2), target2));
        Console.WriteLine("V2: " + PrintResults(TwoSum_V1(nums2, target2), target2));

        // Example 3
        int[] nums3 = { 3, 3 };
        int target3 = 6;

        Console.WriteLine("V1: " + PrintResults(TwoSum_V1(nums3, target3), target3));
        Console.WriteLine("V2: " + PrintResults(TwoSum_V1(nums3, target3), target3));

        Console.WriteLine("");
    }

    public static string PrintResults(int[] vals, int Target)
    {
        if (vals != null)
        {
            return $"{vals[0]} + {vals[1]} ?= {Target}";
        }

        return "Vals was null";
    }

    public static int[] TwoSum_V1(int[] nums, int target)       // Brute force Solution, time complexity of O(n^2)
    {
        // outter loop of nums array
        for (int i = 0; i < nums.Length; i++)
        {
            // inner loop of nums array
            for (int j = 0; j < nums.Length; j++)
            {
                // if num[i] + num[j] == target, we found the required values 
                if (nums[i] + nums[j] == target && i!=j)
                { 
                    return new int[] { nums[j], nums[i] };
                }
            }
        }

        return null;
    }

    public static int[] TwoSum_V2(int[] nums, int target)       // Better Solution, time complexity of O(n)
    {
        // Create a dictionary to store the indices of each number
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {   
            // Calculations
            int complement = target - nums[i];

            // if the dictionary contains the complement, we found the required values
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { nums[numIndices[complement]], nums[i]};
            }

            // Otherwise, add the current number to the dictionary
            numIndices[nums[i]] = i;
        }

        // If no pair of numbers adds up to the target, return an empty array
        return null;
    }
}



