public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length == 0) return new int[] {1};
      
        int d = digits.Length;
        for(int i = d-1; i >= 0; i-- )
        {
            if(digits[i] != 9 )
            {
                digits[i]++;
                return digits;
            }
            
                digits[i] = 0;
            
        }

        int[] res = new int [d + 1];
        res[0] = 1;
        return res;
    }
}