public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        


        var j = new HashSet<int>();
        for(int i =0;i < nums.Length;i++){
            if(j.Contains(nums[i]))
            {
                return true;
            }

            j.Add(nums[i]);

            if(j.Count > k)
            {
                j.Remove(nums[i-k]);
            }
        }

        return false;
    }
}