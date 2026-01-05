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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        int left = GetDepth(root.left,1);
        int right = GetDepth(root.right,1);

         if(left > right ) return left;

        return right;

    }

    public static int GetDepth(TreeNode root, int currentDepth)
    {
        if(root == null) return currentDepth;

        currentDepth++;
        int left = GetDepth(root.left,currentDepth);
        int right = GetDepth(root.right,currentDepth);

        if(left > right ) return left;

        return right;
    }
}