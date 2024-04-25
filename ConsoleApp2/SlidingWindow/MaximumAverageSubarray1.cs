namespace ConsoleApp2.SlidingWindow;

public class MaximumAverageSubarray_
{
    public double findMaxAverage(int[] nums, int k) {
        // Initialize the sum of the first 'k' elements.
        int sum = 0;
        for (int i = 0; i < k; i++) {
            sum += nums[i];
        }

        // Start with the maximum sum as the initial sum.
        int maxSum = sum;

        // Use a sliding window to find the maximum sum of any subarray of size 'k'.
        for (int i = k; i < nums.Length; i++) {
            // Update the sum by removing the element that slides out of the window
            // and adding the element that slides into the window.
            sum = sum - nums[i - k] + nums[i];
            // Update maxSum if the current sum is larger.
            if (sum > maxSum) {
                maxSum = sum;
            }
        }

        // Calculate the average from maxSum and return it.
        return (double)maxSum / k;
    }
}