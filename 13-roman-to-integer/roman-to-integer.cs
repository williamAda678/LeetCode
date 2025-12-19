public class Solution {
    public int RomanToInt(string s) {
         Dictionary<char, int> rn = new Dictionary<char, int>
         {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000},
         };
        int r = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int v = rn[s[i]];
            if (i + 1 < s.Length && rn[s[i + 1]] > v)
            {
                r -= v;
            }
            else
            {
                r += v;
            }
        }   
        
         return r;
    }
}