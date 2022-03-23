/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
        // Traverse whole n-ary tree
        // Keep count of max depth, compare when children == null and reset count to 0
        if (root == null)
        {
            return 0;
        }
        
        var curr = 0;
        
        foreach (var child in root.children)
        {
            curr = Math.Max(curr, MaxDepth(child));
        }
        
        return curr + 1;
    }
}