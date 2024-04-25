namespace ConsoleApp2;

public class CanPlaceFlowers
{
    public bool CanPlaceFlowersSolution(int[] flowerbed, int n)
    {
        int length = flowerbed.Length;
        for (int i = 0; i < length && n > 0; i++)
        {
            if (flowerbed[i] == 0)
            {
                bool left = (i == 0 || flowerbed[i - 1] == 0);
                bool right = (i == length - 1 || flowerbed[i + 1] == 0);

                if (left && right)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
        }
        return n == 0;
    }
}