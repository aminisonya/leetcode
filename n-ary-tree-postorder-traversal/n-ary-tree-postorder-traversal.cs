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
    public IList<int> Postorder(Node root) {
        // Postorder: children, root
        var result = new List<int>();
        return PostorderRecurse(root, result);
    }
    
    public List<int> PostorderRecurse(Node root, List<int> result)
    {
        if (root == null)
        {
            return result;
        }
        
        foreach (var child in root.children)
        {
            PostorderRecurse(child, result);
        }
        
        result.Add(root.val);
        
        return result;
    }
}