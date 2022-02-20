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
    int preorderIndex;
	Dictionary<int, int> inorderDict;
	
	public TreeNode BuildTree(int[] preorder, int[] inorder) {
        preorderIndex = 0;
		inorderDict = new Dictionary<int, int>();
		
		for (var i = 0; i < inorder.Length; i++)
		{
			inorderDict.Add(inorder[i], i);
		}
		
		return ArrayToTree(preorder, 0, preorder.Length - 1);
    }
	
	private TreeNode ArrayToTree(int[] preorder, int left, int right)
	{
		if (left > right) return null;
		
		var rootValue = preorder[preorderIndex];
		preorderIndex++;
		var root = new TreeNode(rootValue);
		
		root.left = ArrayToTree(preorder, left, inorderDict[rootValue] - 1);
		root.right = ArrayToTree(preorder, inorderDict[rootValue] + 1, right);
		return root;
	}
}