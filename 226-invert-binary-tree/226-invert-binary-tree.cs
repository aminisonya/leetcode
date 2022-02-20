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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
		{
			return null;
		}
		
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);
		
		while (queue.Count > 0)
		{
			var curr = queue.Dequeue();
			var temp = curr.left;
			curr.left = curr.right;
			curr.right = temp;
			
			if (curr.left != null) queue.Enqueue(curr.left);
			if (curr.right != null) queue.Enqueue(curr.right);
		}
		
		return root;
    }
}