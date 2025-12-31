public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int idx1 = m-1;
        int idx2 = n-1;
        int idx3 = m + n-1;
        
       while( idx2 >= 0)
       {
            if(idx1 >= 0 && nums1[idx1] > nums2[idx2])
            {
                nums1[idx3] = nums1[idx1];
                idx1--;
                idx3--;
            }
            else
            {
                nums1[idx3] = nums2[idx2];
                idx2--;
                idx3--;
            }
       }
    }
}