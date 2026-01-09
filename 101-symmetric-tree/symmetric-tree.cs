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
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return false;
        return IsSymmetricBST(root.left,root.right);
    }

    public bool IsSymmetricBST(TreeNode left, TreeNode right)
    {
        if(left == null && right == null) return true;
        
        if(left == null || right == null) return false;
        if(left.val != right.val) return false;


        bool l = IsSymmetricBST(left.left,right.right);
        bool r = IsSymmetricBST(left.right,right.left);
       return (l && r) ? true : false;
        
    }
}