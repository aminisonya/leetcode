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
    private int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        // Longest path has to be between two leaf nodes
        // Recursion + DFS
        
        diameter = 0;
        LongestPath(root);
        
        return diameter;
    }
    
    private int LongestPath(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        
        var leftPath = LongestPath(node.left);
        var rightPath = LongestPath(node.right);
        
        diameter = Math.Max(diameter, leftPath + rightPath);
        
        return Math.Max(leftPath, rightPath) + 1;
    }
}