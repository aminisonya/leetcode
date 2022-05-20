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
        // BFS + Queue
        // Row by row, swap left and right children of each node
        // When no children, continue
        
        if (root == null)
        {
            return root;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            if (curr.left != null || curr.right != null)
            {
                // swap the child nodes, then add to queue
                var temp = curr.left;
                curr.left = curr.right;
                curr.right = temp;
                
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
        }
        
        return root;
    }
}