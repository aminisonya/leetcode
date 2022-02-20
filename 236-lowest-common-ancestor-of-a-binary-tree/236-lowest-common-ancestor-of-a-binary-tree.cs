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
        //did we find the node we're looking for? return it
        if (root.val == p.val || root.val == q.val)
		{
			return root;
		}
		//didn't find the p or q AND it's a leaf node? return null, keep going
		if (root.left == null && root.right == null)
		{
			return null;
		}
		
		//recursive calls to search for p or q
		//want to search left and right subtrees of root node
		TreeNode left = null;
		TreeNode right = null;
		
		if (root.left != null)
		{
			left = LowestCommonAncestor(root.left, p, q);
		}
		if (root.right != null)
		{
			right = LowestCommonAncestor(root.right, p, q);
		}
		
		//as we bubble up, do we have a node that has both p and q under it on the left and right sides? that's the node we're looking for
		if (left != null && right != null)
		{
			return root;
		}
		
		 //if we didn't find a node that has both left and right values, means that p and q are on the same side
		//return side with a value
		return left != null ? left : right;
    }
}