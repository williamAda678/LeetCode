public class Solution {
    public bool IsPalindrome(string s) {
    int j = s.Length-1;
    int i = 0;

    while (i<j)
    {
        while(i <j && !char.IsLetterOrDigit(s[i]) != false) i++;
        while( i <j && !char.IsLetterOrDigit(s[j]) != false) j--;

        if(char.ToLowerInvariant( s[i]) !=char.ToLowerInvariant( s[j])) return false;
        i++;
        j--;
    }
    return true;
    }
}