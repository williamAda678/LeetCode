public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var seen = new Dictionary <int, int>();
        int target =  nums.Length /2;

        foreach (int num in nums)
        {
          
            if(seen.ContainsKey(num))
            {
                    return num;
            }
            else
            {
                seen.Add(num, 1);
            }

        }

        return 0;
    }
}