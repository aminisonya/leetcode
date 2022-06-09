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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // Create a list for each level. Add list to result set.
        // BFS + Queue
        // While loop and inner while loop for iterating thru current level
        
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var size = queue.Count; // This will tell us how many are in current level
            var list = new List<int>();
            
            // Inner loop to iterate thru items in this level of the tree
            for (var i = 0; i < size; i++)
            {                
                var curr = queue.Dequeue();
                list.Add(curr.val);
                
                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
            
            result.Add(list);
        }
        
        return result;
    }
}