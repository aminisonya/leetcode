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
        // DFS + Recursion
		// Create dictionary to keep track of visited nodes
        var dict = new Dictionary<Node, Node>();
		return Clone(node, dict);
    }
	
	private Node Clone(Node node, Dictionary<Node, Node> dict)
	{
		if (node == null)
		{
			return null;
		}
		
		// Check if node has NOT already been visited
		if (!dict.ContainsKey(node))
		{
			// Add node + clone of node to mark it as visited
			dict.Add(node, new Node(node.val));
			
			// Clone neighboring nodes by iterating thru them
			// Add cloned nodes to list of neighbors as you go
			foreach (var n in node.neighbors)
			{
				dict[node].neighbors.Add(Clone(n, dict));
			}
		}
		
		return dict[node];
	}
}