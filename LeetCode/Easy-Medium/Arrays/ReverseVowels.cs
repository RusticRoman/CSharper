namespace ConsoleApp2;

public class ReverseVowels
{
    public string ReverseVowelsSolution(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var characters = s.ToCharArray();
        var left = 0;
        var right = characters.Length - 1;
        for (; left < right;)
        {
            if (vowels.Contains(characters[left]) == false)
            {
                left++;
                continue;
            }

            if (vowels.Contains(characters[right]) == false)
            {
                right--;
                continue;
            }

            (characters[left], characters[right]) = (characters[right], characters[left]);
            left++;
            right--;
        }

        return new string(characters);
    }
}