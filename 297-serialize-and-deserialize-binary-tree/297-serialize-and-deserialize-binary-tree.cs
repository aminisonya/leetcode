/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec 
{
    // Encodes a tree to a single string.
		public string serialize(TreeNode root) {
            //BFS approach using a queue
			var result = new List<string>();
			
			if (root == null)
			{
				return "";
			}
			
			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			
			while (queue.Count > 0)
			{
				var size = queue.Count;
				
				for (var s = 0; s < size; s++)
				{
					var curr = queue.Dequeue();
					
					if (curr == null)
					{
						result.Add("n");
						continue;
					}
					else
					{
						result.Add(curr.val.ToString());
					}
					
					queue.Enqueue(curr.left);
					queue.Enqueue(curr.right);
				}				
			}
			
			return string.Join(",", result);
		}

		// Decodes your encoded data to tree.
		public TreeNode deserialize(string data) {
			if (data == "")
			{
				return null;
			}
			
			var list = data.Split(',');
			var root = new TreeNode(int.Parse(list[0]));
			
			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			var i = 1;
			
			while (queue.Count > 0 && i < list.Length)
			{
				var curr = queue.Dequeue();
				if (list[i] != "n")
				{
					curr.left = new TreeNode(int.Parse(list[i]));
					queue.Enqueue(curr.left);
				}
				i++;
				
				if (list[i] != "n")
				{
					curr.right = new TreeNode(int.Parse(list[i]));
					queue.Enqueue(curr.right);
				}
				i++;
			}
			
			return root;
		}
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));