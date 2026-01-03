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
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        int leftNodeDepth = CountLeftNodes(root);
        int rightNodeDepth = CountRightNodes(root);

        if(leftNodeDepth == rightNodeDepth)
        {    
            return (int) Math.Pow(2, leftNodeDepth) -1;
        }

        return  1 + CountNodes(root.left) + CountNodes(root.right);
    }

    public int CountLeftNodes(TreeNode root) {
        int count =0;
        while(root != null)
        {
            root = root.left;
            count++;
        }
        return  count;
    }

    public int CountRightNodes(TreeNode root) {
        int count =0;
        while(root != null)
        {
            root = root.right;
            count++;
        }
        return  count;
    }
}