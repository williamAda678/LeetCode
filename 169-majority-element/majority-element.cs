public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length == 1) return nums[0];
        Dictionary<int,int> seen = new Dictionary<int,int>();
        int mid =nums.Length/2;
        foreach(int num in nums)
        {    
            if(seen.ContainsKey(num))
            {
              seen[num]++;
              if(seen[num] > mid )
              {
                return num;
              }
            }
            else
            {
            seen.Add(num, 1);
            }
        }
        return 0;
    }
}