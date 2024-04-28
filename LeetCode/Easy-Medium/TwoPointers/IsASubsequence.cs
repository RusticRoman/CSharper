namespace ConsoleApp2;

public class IsASubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        var position = 0;
        for (var i = 0; i < t.Length; i++)
        {
            if (position == s.Length) return true;
            if (s[position] == t[i]) position++;
        }

        if (position == s.Length) return true;
        return false;
    }
}