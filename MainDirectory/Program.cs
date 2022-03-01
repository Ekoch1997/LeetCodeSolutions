using System;

namespace MainDirectory
{
    class Program
    {
        public static void Main(string[] args)
        {
            var instance = new TwoSumSolution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] Solution = instance.TwoSum(nums, target);
            foreach (int i in Solution)
                Console.WriteLine(i);

            int[] Solution2 = instance.TwoSumSecondPass(nums, target);
            foreach (int i in Solution2)
                Console.WriteLine(i);
        }
    }
}