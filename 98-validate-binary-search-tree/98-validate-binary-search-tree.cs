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
        return Validate(root, null, null);
    }
    
    public bool Validate(TreeNode root, int? low, int? high)
    {
        // Empty trees are valid BSTs
        if (root == null)
        {
            return true;
        }
        
        // The current nodes value must be between low and high
        if ((low != null && root.val <= low) || (high != null && root.val >= high))
        {
            return false;
        }
        
        // The left and right subtree must also be valid
        return Validate(root.left, low, root.val)
            && Validate(root.right, root.val, high);
    }
}