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
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        
        if (root == null) return result;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var size = queue.Count;
            var currList = new List<int>();
            
            for (var i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                currList.Add(curr.val);
                
                foreach (var child in curr.children)
                {
                    queue.Enqueue(child);
                }
            }
            
            result.Add(currList);
        }
        
        return result;
    }
}