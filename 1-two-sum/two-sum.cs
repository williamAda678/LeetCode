public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sum = new Dictionary<int, int>(); 

        for(int i =0;i< nums.Length; i++){
            int currentTotal =   target - nums[i]; 
            if(sum.ContainsKey(currentTotal))
            {
                return new int[] { sum[currentTotal], i};
            }
            sum[nums[i]]=i;
        }

        return new int[] {};
    }
}