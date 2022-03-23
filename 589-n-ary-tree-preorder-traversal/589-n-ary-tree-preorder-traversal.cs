/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        // Preorder: root, children
        
        var result = new List<int>();
        
        if (root == null)
        {
            return result;
        }
        
        var stack = new Stack<Node>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            
            result.Add(curr.val);
            
            if (curr.children != null)
            {
                for (var i = curr.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(curr.children[i]);
                }
            }            
        }
        
        return result;
    }
}