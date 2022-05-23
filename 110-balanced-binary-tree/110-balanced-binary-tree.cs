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
    public bool balanced = true;
    
    public bool IsBalanced(TreeNode root) {
        // Balanced tree is when EACH NODE has balanced subtree
        // Recursively check left and right heights of each node and compare
        // If ever there's a difference of > 1, then not balanced
        // Base case: after leaf node, return 0
        
        DFS(root);        
        return balanced;
    }
    
    public int DFS(TreeNode node)
    {
        // Base case
        if (node == null || balanced == false)
        {
            return 0;
        }
        
        var leftHeight = DFS(node.left);
        var rightHeight = DFS(node.right);
        
        if (Math.Abs(leftHeight - rightHeight) > 1)
        {
            balanced = false;
        }
        
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}