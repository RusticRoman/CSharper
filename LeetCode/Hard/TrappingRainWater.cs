using System;

namespace ConsoleApp2.Hard;

/**
    To solve the "Trapping Rain Water" problem in C#, the idea is to calculate how much water can be trapped between the bars on the elevation map. We can use two pointers to traverse the height list from both ends and use two arrays (or pointers in an optimized solution) to keep track of the maximum heights from both the left and the right for each position.

    Here's how you can implement this solution in C#:

    Use two pointers to maintain the maximum heights from the left (leftMax) and the right (rightMax).
    Traverse the height list from both ends, adjusting the maximum values and calculating the trapped
    water for each position by taking the minimum of leftMax and rightMax minus the current height.
 */
public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int n = height.Length;
        int left = 0, right = n - 1;
        int leftMax = height[left], rightMax = height[right];
        int trappedWater = 0;

        while (left <= right)
        {
            if (leftMax < rightMax)
            {
                if (height[left] < leftMax)
                {
                    trappedWater += leftMax - height[left];
                }

                leftMax = Math.Max(leftMax, height[left]);
                left++;
            }
            else
            {
                if (height[right] < rightMax)
                {
                    trappedWater += rightMax - height[right];
                }

                rightMax = Math.Max(rightMax, height[right]);
                right--;
            }
        }

        return trappedWater;
    }
}

// class Program {
//     static void Main() {
//         var solution = new TrappingRainWater();
//         Console.WriteLine(solution.Trap(new int[] {0,1,0,2,1,0,1,3,2,1,2,1})); // Output: 6
//         Console.WriteLine(solution.Trap(new int[] {4,2,0,3,2,5})); // Output: 9
//     }
// }