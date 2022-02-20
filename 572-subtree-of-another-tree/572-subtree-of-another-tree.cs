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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) return false;
		if (IsIdentical(root, subRoot)) return true;
		
		return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
	}
	
	public bool IsIdentical(TreeNode s, TreeNode t)
	{
		if (s == null && t == null) return true;
		if (s == null || t == null) return false;
		
		if (s.val != t.val) return false;
		
		return IsIdentical(s.left, t.left) && IsIdentical(s.right, t.right);
	}
}