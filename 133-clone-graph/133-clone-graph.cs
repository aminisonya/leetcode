/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        // DFS + Recursion. Hashset to keep track of visited nodes
        
        var dict = new Dictionary<Node, Node>(); // original : clone
        return Clone(node, dict);
    }
    
    private Node Clone(Node node, Dictionary<Node, Node> dict)
    {
        // Base case
        if (node == null)
        {
            return null;
        }
        
        // Check if in dict. If not, add it and its clone
        // Don't want to revisit a node that's already been visited
        if (!dict.ContainsKey(node))
        {
            var clone = new Node(node.val);
            dict.Add(node, clone);            
            
            foreach (var neighbor in node.neighbors)
            {
                clone.neighbors.Add(Clone(neighbor, dict));
            }
        }
        
        return dict[node];
    }
}