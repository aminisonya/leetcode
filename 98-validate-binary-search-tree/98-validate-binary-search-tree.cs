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
    public bool IsValidBST(TreeNode root) {
        // DFS + Recursion
        // Keep track of min and max range, compare each node value to that
        
        return IsValid(root, null, null);
    }
    
    private bool IsValid(TreeNode node, int? min, int? max)
    {
        if (node == null)
        {
            return true;
        }
        
        if (min != null && node.val <= min || max != null && node.val >= max)
        {
            return false;
        }
        
        return IsValid(node.left, min, node.val) && IsValid(node.right, node.val, max);
    }
}