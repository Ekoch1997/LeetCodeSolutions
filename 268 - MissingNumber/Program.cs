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

            int[] nums = {0, 1, 2, 3, 4, 6, 7};

            Console.WriteLine(instance.MissingNumber(nums));

        }

        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int sum = nums.Sum(x => x);
            return ((n * n + n) / 2) - sum;
        }
    }
}
