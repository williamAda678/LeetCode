public class Solution {
    public int ClimbStairs(int n) {
        
        if(n == 0) return 0;
        if(n == 1) return 1;


        int current = 0;
        int prev1 = 0;
        int prev2 = 1;
        for(int i =0; i<= n;i++)
        {
            current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }

        return current;
    }
}