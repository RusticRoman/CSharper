namespace ConsoleApp2;

public class CanPlaceFlowers
{
    public bool CanPlaceFlowersSolution(int[] flowerbed, int n)
    {
        var length = flowerbed.Length;
        for (var i = 0; i < length && n > 0; i++)
            if (flowerbed[i] == 0)
            {
                var left = i == 0 || flowerbed[i - 1] == 0;
                var right = i == length - 1 || flowerbed[i + 1] == 0;

                if (left && right)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

        return n == 0;
    }
}