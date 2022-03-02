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

            int[] nums = { 2, 2, 1, 3, 4, 4, 7 };

            instance.FindDisappearedNumbers(nums);
            instance.FindDisappearedNumbers_Solution2(nums);

        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;
            IList<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                result.Add(i);
            }

            for (int i = 0; i < n; i++)
            {
                result[nums[i]-1] = 0;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (result[i] == 0)
                    result.RemoveAt(i);
            }

            return result;
        }

        public IList<int> FindDisappearedNumbers_Solution2(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                nums[Math.Abs(nums[i]) - 1] = -Math.Abs(nums[Math.Abs(nums[i]) - 1]);
            }

            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }

            return result;
        }
    }
}
