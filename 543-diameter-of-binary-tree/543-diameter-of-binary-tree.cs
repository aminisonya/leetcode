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
        // Find longest path between two nodes
        // Must be leaf nodes
        // Use Recursion and DFS to find longest paths of each node
        
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
        
        // If found a greater diameter, replace diameter value
        if (leftPath + rightPath > diameter)
        {
            diameter = leftPath + rightPath;
        }
        
        // Add 1 before returning
        return leftPath > rightPath ? leftPath + 1 : rightPath + 1;
    }
}