public class Solution {
    public int MissingNumber(int[] nums) {
        var a = new HashSet<int>(nums);

        for(int i = 0; i <= nums.Length; i++){
            if(!a.Contains(i))return i;
        }
        return 0;
    }
}