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

            int[] nums = { 2, 2, 10, 3, 4, 4, 3 };

            Console.WriteLine(instance.SingleNumber(nums));

        }

        public int SingleNumber(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
                answer ^= nums[i];

            return answer;
        }
    }
}
