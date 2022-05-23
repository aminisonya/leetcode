/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // BST
        // Bc it's a BST, we know we can use that for searching in O(log n) if needed
        // We are searching for p and q, and their "split point". What node do they split at (one goes to the right, one to the left)? That's the LCA
        // If one is parent of other, that's also LCA
        // While loop until LCA is found
        
        var pVal = p.val;
        var qVal = q.val;
        var node = root;
        
        while (node != null)
        {
            if (node.val > pVal && node.val > qVal)
            {
                node = node.left;
            }
            else if (node.val < pVal && node.val < qVal)
            {
                node = node.right;
            }
            else if (node.val == pVal)
            {
                return p;
            }
            else if (node.val == qVal)
            {
                return q;
            }
            else
            {
                return node;
            }
        }
        
        return root;
    }
}