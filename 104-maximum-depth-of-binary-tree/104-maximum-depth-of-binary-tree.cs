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
        if (root == null)
		{
			return 0;
		}
		
		var max = 0;
		var stack = new Stack<TreeNode>();
		var depths = new Stack<int>();
		stack.Push(root);
		depths.Push(1);
		
		while (stack.Count > 0)
		{
			var curr = stack.Pop();
			var depth = depths.Pop();
			
			if (curr.right != null)
			{
				stack.Push(curr.right);
				depths.Push(depth + 1);
			}
			if (curr.left != null)
			{
				stack.Push(curr.left);
				depths.Push(depth + 1);
			}
			
			if (curr.right == null && curr.left == null)
			{
				max = Math.Max(max, depth);
			}
		}
		
		return max;
    }
}