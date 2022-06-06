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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Recursion
        // Go thru both trees and check values at each node
        // Establish base cases
        // These are the cases where we want to bubble up the FINAL answer
        // Only want to bubble up the answer when we've found that the trees do not match
        // OR when we've reached the final nodes
        
        if (p == null && q == null)
        {
            return true;
        }
        
        if (p == null || q == null)
        {
            return false;
        }
        
        if (p.val != q.val)
        {
            return false;
        }
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}