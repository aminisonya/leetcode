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
        var curr = root;
		
		if (p.val > curr.val && q.val > curr.val)
		{
			return LowestCommonAncestor(curr.right, p, q);
		} else if (p.val < curr.val && q.val < curr.val)
		{
			return LowestCommonAncestor(curr.left, p, q);
		} else 
		{
			return curr;
		}
		
		return null;
    }
}