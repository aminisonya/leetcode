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
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        // BFS + Queue of Tuples, node and col
        // Dict of col and list of vals in that col
        // Keep track of minCol and maxCol vals
        
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }
        
        var queue = new Queue<(TreeNode, int)>();
        var dict = new Dictionary<int, List<int>>();
        var minCol = 0;
        var maxCol = 0;
        var col = 0;
        queue.Enqueue((root, col));
        
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            root = curr.Item1;
            col = curr.Item2;
            
            if (root != null)
            {
                if (!dict.ContainsKey(col))
                {
                    dict.Add(col, new List<int>());
                }
                dict[col].Add(root.val);
                
                // Update mincol and maxcol as we go through
                minCol = Math.Min(minCol, col);
                maxCol = Math.Max(maxCol, col);
                
                // Enqueue child nodes and col vals
                queue.Enqueue((root.left, col - 1));
                queue.Enqueue((root.right, col + 1));
            }            
        }
        
        // Loop thru min col to max col vals and add lists from dict to result
        for (var i = minCol; i <= maxCol; i++)
        {
            result.Add(dict[i]);
        }
        
        return result;
    }
}