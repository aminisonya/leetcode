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
        // DFS using a Stack. Iterative approach. Preorder: root, left, right
        // Pop off stack, check current nodes value. Add values to overall sum if between low and high vals
        // If curr > low, add left child. If curr < high, add right child.
        
        var sum = 0;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            
            if (curr.val >= low && curr.val <= high)
            {
                sum += curr.val;
            }
            
            if (curr.val > low && curr.left != null)
            {
                stack.Push(curr.left);
            }
            
            if (curr.val < high && curr.right != null)
            {
                stack.Push(curr.right);
            }
        }
        
        return sum;
    }
}