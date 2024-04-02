using System;

namespace MiniMaxSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 9, 2 };
            int[] numbers2 = { 1, 3, 5, 7, 9 };
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            var minMaxSum = MiniMaxSum(numbers);
            Console.WriteLine($"Min Sum: {minMaxSum[1]}");
            Console.WriteLine($"Max Sum: {minMaxSum[0]}");
            var minMaxSum2 = MiniMaxSum(numbers2);
            Console.WriteLine($"Min Sum: {minMaxSum2[1]}");
            Console.WriteLine($"Max Sum: {minMaxSum2[0]}");
            var minMaxSum3 = MiniMaxSum(numbers3);
            Console.WriteLine($"Min Sum: {minMaxSum3[1]}");
            Console.WriteLine($"Max Sum: {minMaxSum3[0]}");
        }
        public static int[] MiniMaxSum(int[] nums)
        {
            var sum = 0;
            var numberMax = nums[0];
            var numberMin = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                numberMax = Math.Max(numberMax, nums[i]);
                numberMin = Math.Min(numberMin, nums[i]);
            }
            var maxSum = sum - numberMin;
            var minSum = sum - numberMax;
            return new int[] { maxSum, minSum };
        }
    }
}
