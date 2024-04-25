namespace ConsoleApp2.TwoPointers;

public class MoveZeroes
{
    public void MoveZeroesSolution(int[] nums) {
        int position = 0;
        foreach (int num in nums)
        {
            if (num != 0)
            {
                nums[position] = num;
                position++;
            }
        }
        for (int i = position; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}