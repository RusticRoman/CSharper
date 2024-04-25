namespace ConsoleApp2.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxVolume = 0;
        while (left < right)
        {
            int minHeight = Math.Min(height[left], height[right]);
            maxVolume = Math.Max(minHeight * (right - left), maxVolume);
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxVolume;
    }
}