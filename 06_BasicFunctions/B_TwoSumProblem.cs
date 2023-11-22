using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT
 * This is a leetcode challenge (easy level) with the following description:
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

 

Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.
*/

namespace _06_BasicFunctions
{
    class B_TwoSumProblem
    {
        public static void Main(String[] args)
        {
            //declaring the values (hardcoded)
            int[] firstArray = new int[3];
            firstArray[0] = 1;
            firstArray[1] = 2;
            firstArray[2] = 3;

            int targetValue = 5;//this is the value we want to calculate from the values within our array

            TwoSum(firstArray,targetValue);

            Console.ReadKey();//keeping the command prompt alive
        }//end main

        //method to solve the problem
        public static int[] TwoSum(int[] nums, int target)
        {
            //output the values
            Console.WriteLine($"Array: [{string.Join(", ", nums)}]");//outputting the array like this shows contents of the array
            Console.WriteLine($"Target: {target}");

            //looping through the values of the array
            for (int i = nums[0]; i <= nums.Length; i++)
            {
                Console.WriteLine(i);
            }

            return nums;
        }
    }//end class
}//end namespace
