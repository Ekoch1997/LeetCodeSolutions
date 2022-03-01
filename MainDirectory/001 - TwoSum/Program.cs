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

            int[] list = { 15, 8, 6, 13, 52, 42, 0, 1, 6, 2 };

            int[] result = TwoSum(list, 12);

            foreach (int i in result)
            Console.WriteLine(i);

            int[] result2 = TwoSum(list, 12);

            foreach (int i in result2)
                Console.WriteLine(i);
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            bool isSorted = false;

            int[] sortedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                sortedNums[i] = nums[i];

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 1; i < sortedNums.Length; i++)
                {


                    if (sortedNums[i] < sortedNums[i - 1])
                    {
                        int cur = sortedNums[i];
                        sortedNums[i] = sortedNums[i - 1];
                        sortedNums[i - 1] = cur;
                        isSorted = false;

                    }
                }
            }

            int startIndex = 0;
            int endIndex = sortedNums.Length - 1;
            while (true)
            {
                if (sortedNums[startIndex] + sortedNums[endIndex] > target)
                    endIndex--;
                if (sortedNums[startIndex] + sortedNums[endIndex] < target)
                    startIndex++;
                if (sortedNums[startIndex] + sortedNums[endIndex] == target)
                    break;
            }

            int startNum = sortedNums[startIndex];
            int endNum = sortedNums[endIndex];

            int[] answer = new int[2];
            bool firstFound = false;
            for (int i = 0; i < sortedNums.Length; i++)
            {
                if (nums[i] == startNum && !firstFound)
                {
                    answer[0] = i;
                    firstFound = true;
                }
                else if (nums[i] == endNum)
                {
                    answer[1] = i;
                }

            }
            return answer;
        }



        public int[] TwoSum_Solution2(int[] nums, int target)
        {
            IDictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int[] answer = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(target - nums[i]))
                {
                    answer[0] = i;
                    answer[1] = keyValuePairs[target - nums[i]];
                    return answer;
                }
                else
                {
                    keyValuePairs[nums[i]] = i;
                }
            }
            return answer;
        }
    }
}
