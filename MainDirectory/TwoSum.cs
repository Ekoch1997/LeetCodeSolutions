using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDirectory
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
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

        public int[] TwoSumSecondPass(int[] nums, int target)
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
                keyValuePairs[nums[i]] = i;
            }
            return answer;
        }
    }
}
