namespace ConsoleApp2.TwoPointers;

public class MoveZeroes
{
    public void MoveZeroesSolution(int[] nums)
    {
        var position = 0;
        foreach (var num in nums)
            if (num != 0)
            {
                nums[position] = num;
                position++;
            }

        for (var i = position; i < nums.Length; i++) nums[i] = 0;
    }
}