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
    public int maxPath = Int32.MinValue;
	
	public int MaxPathSum(TreeNode root)
	{
        GetMaxGain(root);
		return maxPath;
    }
	
	public int GetMaxGain(TreeNode node)
	{
		if (node == null)
		{
			return 0;
		}
		
		var gainOnLeft = Math.Max(GetMaxGain(node.left), 0);
		var gainOnRight = Math.Max(GetMaxGain(node.right), 0);
		
		var currentMaxPath = node.val + gainOnLeft + gainOnRight;
		maxPath = Math.Max(maxPath, currentMaxPath);
		
		return node.val + Math.Max(gainOnLeft, gainOnRight);
	}
}