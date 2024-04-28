namespace ConsoleApp2;

public class KidsWithCandies
{
    public IList<bool> KidsWithCandiesCalc(int[] candies, int extraCandies)
    {
        //find max potential candies in the whole array
        var maxCandies = 0;
        foreach (var candiesPerChild in candies)
            if (candiesPerChild > maxCandies)
                maxCandies = candiesPerChild;
        var result = new List<bool>();
        for (var i = 0; i < candies.Length; i++) result.Add(candies[i] + extraCandies >= maxCandies);
        return result;
    }
}