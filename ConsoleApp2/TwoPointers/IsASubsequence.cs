namespace ConsoleApp2;

public class IsASubsequence
{
    public bool IsSubsequence(string s, string t) {
        int position = 0;
        for (int i=0; i<t.Length; i++){
            if(position == s.Length) return true;
            if(s[position] == t[i]) position++;
        }
        if(position == s.Length) return true;
        return false;
    }
}