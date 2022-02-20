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
    Stack<TreeNode> stack = new Stack<TreeNode>();
	Stack<int?> lowerLimits = new Stack<int?>();
	Stack<int?> upperLimits = new Stack<int?>();
	
	public bool IsValidBST(TreeNode root) {
        int? low = null;
		int? high = null;
		int? val = null;
		Update(root, low, high);
		
		while (stack.Count > 0)
		{
			root = stack.Pop();
			low = lowerLimits.Pop();
			high = upperLimits.Pop();
			
			if (root == null) continue;
			
			val = root.val;
			if (low != null && val <= low)
			{
				return false;
			}
			if (high != null && val >= high)
			{
				return false;
			}
			
			Update(root.right, val, high);
			Update(root.left, low, val);
		}
		
		return true;
    }
	
	public void Update(TreeNode root, int? low, int? high)
	{
		stack.Push(root);
		lowerLimits.Push(low);
		upperLimits.Push(high);
	}
}