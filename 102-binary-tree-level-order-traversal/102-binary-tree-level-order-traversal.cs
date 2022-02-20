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
    public IList<IList<int>> LevelOrder(TreeNode root)
	{
	    var levelsList = new List<IList<int>>();
		if (root == null)
		{
			return levelsList;
		}		
		
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);
		
		while (queue.Count > 0)
		{
			var size = queue.Count;
			var list = new List<int>();
			for (var i = 0; i < size; i++)
			{
				var curr = queue.Dequeue();
				list.Add(curr.val);
				
				if (curr.left != null) queue.Enqueue(curr.left);
				if (curr.right != null) queue.Enqueue(curr.right);
			}
			
			levelsList.Add(list);
		}
		
		return levelsList;
	}
}