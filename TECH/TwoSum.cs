using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{

// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Example:
//Given nums = [2, 7, 11, 15], target = 9,
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1]s;.
//Time Complexity: O(n)
    public static class TwoSum
    {
        public static int[] FindtargetIndex(int[] nums,int target)
        {
            Dictionary<int, int> Hashmap = new Dictionary<int, int>();
            int[] returnIndexes = new int[2];
            foreach (var item in nums)
            {
                Console.Write(" ");
                Console.Write(item);
            }
            for (int index = 0; index < nums.Length; index++) {
                int difference = target - nums[index];
                if (Hashmap.Count > 0)
                {
                    foreach (KeyValuePair<int, int> diffvalue in Hashmap)
                    {
                        if (diffvalue.Value == nums[index])
                        {
                            returnIndexes[0] = diffvalue.Key;
                            returnIndexes[1] = index;
                            return returnIndexes;
                        }

                    }

                                    }
                Hashmap.Add(index, difference);
            }
            Console.WriteLine(" No number in integer array matches the target value: {0}", target);
            return returnIndexes;
        }
    }
}
