namespace ConsoleApp2;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var answer = new int[n];

        // Use answer array to store the prefix products
        answer[0] = 1;
        for (var i = 1; i < n; i++) answer[i] = answer[i - 1] * nums[i - 1];

        // Calculate the suffix product and update the answer array on the fly
        var suffixProduct = 1; // To store the suffix product
        for (var i = n - 1; i >= 0; i--)
        {
            answer[i] = answer[i] * suffixProduct; // Multiply by suffix product so far
            suffixProduct *= nums[i]; // Update the suffix product
        }

        return answer;
    }
}