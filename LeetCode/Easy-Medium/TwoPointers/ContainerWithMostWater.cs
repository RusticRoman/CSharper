namespace ConsoleApp2.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxVolume = 0;
        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            maxVolume = Math.Max(minHeight * (right - left), maxVolume);
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxVolume;
    }
}