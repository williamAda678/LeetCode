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
    public int SumOfLeftLeaves(TreeNode root) {
        if(root == null) return 0;
        return GetLeftLeavesValue(root,0);
    }

     public int GetLeftLeavesValue(TreeNode root, int current) {
        if(root == null) return current;

        if(root.left != null &&
        root.left.left == null && root.left.right == null)
        {
            current += root.left.val;
        }

        current = GetLeftLeavesValue(root.left, current);
        current = GetLeftLeavesValue(root.right, current);

        return current;
        
    }
}