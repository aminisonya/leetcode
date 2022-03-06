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
        //base case: reached a leaf node?
        //recurse on left and right leaf nodes?
        //keep count of max depth        
        if (root == null)
        {
            return 0;
        }
        
        return CalcMax(root, 1);
    }
    
    public int CalcMax(TreeNode root, int max)
    {
        if (root == null)
        {
            return max;
        }
        
        var left = 0;
        var right = 0;
        
        if (root.left != null)
        {
            left = CalcMax(root.left, max);
        }
        
        if (root.right != null)
        {
            right = CalcMax(root.right, max);
        }
        
        return Math.Max(left, right) + 1;
    }
}