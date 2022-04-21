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
    public int RangeSumBST(TreeNode root, int low, int high) {
        // Recursion + DFS
        // Without class level variable, to keep code thread safe
        
        var sum = DFS(root, low, high, 0);
        
        return sum;
    }
    
    public int DFS(TreeNode root, int low, int high, int sum)
    {
        if (root != null)
        {
            if (root.val >= low && root.val <= high)
            {
                sum += root.val;
            }
            
            if (root.val > low)
            {
                sum = DFS(root.left, low, high, sum);
            }
            
            if (root.val < high)
            {
                sum = DFS(root.right, low, high, sum);
            }
        }
        
        return sum;
    }
}