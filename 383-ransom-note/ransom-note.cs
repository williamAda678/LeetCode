public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        if(magazine.Length < ransomNote.Length) return false;

        Dictionary<char,int> count = new Dictionary<char,int>();

        foreach(char m in magazine){
            if(count.ContainsKey(m))
            {
                count[m]++;
            }
            else{
            count[m]=1;
            }
        }

        foreach( char r in ransomNote)
        {
            if(!count.ContainsKey(r) || count[r] ==0)
            {
                return false;
            }

            count[r]--;
        }


        return true;
    }
}