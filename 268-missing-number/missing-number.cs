public class Solution {
    public int MissingNumber(int[] nums) {
        int current = 0;
        int target = nums.Length * (nums.Length + 1) /2;
      
        for(int i = 0; i < nums.Length; i++){
            current += nums[i];
        }
        return target - current;
    }
}