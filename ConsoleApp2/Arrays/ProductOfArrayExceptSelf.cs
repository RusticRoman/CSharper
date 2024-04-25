namespace ConsoleApp2;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];

        // Use answer array to store the prefix products
        answer[0] = 1;
        for (int i = 1; i < n; i++) {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // Calculate the suffix product and update the answer array on the fly
        int suffixProduct = 1;  // To store the suffix product
        for (int i = n - 1; i >= 0; i--) {
            answer[i] = answer[i] * suffixProduct;  // Multiply by suffix product so far
            suffixProduct *= nums[i];  // Update the suffix product
        }

        return answer;
    }
}