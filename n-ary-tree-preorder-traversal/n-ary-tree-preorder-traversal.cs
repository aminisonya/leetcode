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
        return PreorderRecurse(root, result);
    }
    
    public List<int> PreorderRecurse(Node root, List<int> result)
    {
        if (root == null)
        {
            return result;
        }
        
        result.Add(root.val);
        
        foreach (var child in root.children)
        {
            PreorderRecurse(child, result);
        }
        
        return result;
    }
}