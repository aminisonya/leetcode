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
    public int RangeSumBST(TreeNode root, int low, int high) {
        // DFS - preorder: root, left, right
        // Check each node value, only continue when higher than low or lower than high
        // Add values to overall sum
        
        var sum = 0;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            
            if (curr.val >= low && curr.val <= high)
            {
                Console.WriteLine(curr.val);
                sum += curr.val;
            }
            
            if (curr.left != null)
            {
                stack.Push(curr.left);
            }
            
            if (curr.right != null)
            {
                stack.Push(curr.right);
            }
        }
        
        return sum;
    }
}