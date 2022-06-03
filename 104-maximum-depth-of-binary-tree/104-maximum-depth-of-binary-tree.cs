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
        // Recursion + DFS
        // Looking for farthest leaf node
        
        if (root == null)
        {
            return 0;
        }
        
        return FindMax(root);
    }
    
    private int FindMax(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        
        var leftMax = FindMax(node.left);
        var rightMax = FindMax(node.right);
        
        return Math.Max(leftMax, rightMax) + 1;
    }
}