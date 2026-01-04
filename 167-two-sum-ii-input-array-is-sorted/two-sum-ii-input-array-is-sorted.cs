public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       int l = 0;
       int r = numbers.Length -1;
       int current = numbers[l] + numbers[r];
       while( current != target)
       {
            if(current > target)
            {
                r--;
            }
            else
            {
                l++;
            }
            current = numbers[l] + numbers[r];
       } 
    
        return new int []{l+1,r+1};
    }
}