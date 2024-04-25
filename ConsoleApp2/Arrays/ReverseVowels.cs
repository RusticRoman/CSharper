namespace ConsoleApp2;

public class ReverseVowels
{
    public string ReverseVowelsSolution(string s)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] characters = s.ToCharArray();
        int left = 0;
        int right = characters.Length - 1;
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