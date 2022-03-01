using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var instance = new Solution();

            int[] list = { 15, 8, 6, 13, 52, 42, 0, 1, 6, 2 };

            Console.WriteLine(instance.ContainsDuplicate(list));
        }

        public bool ContainsDuplicate(int[] nums)
        {
            IDictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                    return true;

                keyValuePairs[nums[i]] = i;
            }
            return false;
        }
    }
}
