public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        for(int i =0; i<=numbers.Length;i++)
            {
            
            for(int j = i; j <numbers.Length;j++)
                {
                    int current = numbers[i] + numbers[j];
                    if(current == target && i !=j)
                    {
                        return new int[]{i+1,j+1};
                    }

                    if(current > target) break;
                }   
            
            } 

            return new int[]{0};        
    }
}