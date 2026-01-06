/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if(root == null) return root; 
        invertOdd(root.left,root.right,1);
        
        return root;
    }

    public void  invertOdd(TreeNode left,TreeNode right, int level)
    {
        if(right==null || left == null) return;
        if(level % 2 == 1)
        {
            var temp = left.val;
            left.val = right.val;
            right.val = temp;
        }

        invertOdd(left.left,right.right, level +1);
        invertOdd(left.right,right.left, level +1);
      
    }
}