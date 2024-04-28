using System.Text;

namespace ConsoleApp2;

public class ReverseWordsInString
{
    public string ReverseWords(string s)
    {
        var words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var reversed = new StringBuilder();

        for (var i = words.Length - 1; i > 0; i--)
        {
            reversed.Append(words[i]);
            reversed.Append(" ");
        }

        if (words.Length > 0) reversed.Append(words[0]); // Append the first word without an extra space

        return reversed.ToString();
    }
}