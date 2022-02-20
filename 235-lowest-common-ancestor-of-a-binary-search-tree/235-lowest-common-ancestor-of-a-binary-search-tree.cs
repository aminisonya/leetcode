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
        var pVal = p.val;
		var qVal = q.val;
		var curr = root;
		
		while (curr != null)
		{
			if (pVal > curr.val && qVal > curr.val)
			{
				curr = curr.right;
			} else if (pVal < curr.val && qVal < curr.val)
			{
				curr = curr.left;
			} else
			{
				return curr;
			}
		}
		
		return null;
    }
}