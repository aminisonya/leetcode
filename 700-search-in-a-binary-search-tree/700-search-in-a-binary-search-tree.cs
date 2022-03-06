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
    public TreeNode SearchBST(TreeNode root, int val) {
        //base case: reached leaf node, did not find value OR found value
        
        if (root == null || root.val == val)
        {
            return root;
        }
        
        if (root.val > val)
        {
            return SearchBST(root.left, val);
        }
        
        if (root.val < val)
        {
            return SearchBST(root.right, val);
        }
        
        return root;
    }
}