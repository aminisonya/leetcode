/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        // BFS + Queue to traverse level by level
        // Have an inner loop in the while loop while traversing Queue
        // Iterate thru all nodes on current level, updating next nodes and adding children to queue
        
        if (root == null) return root;
        
        var nodeQueue = new Queue<Node>();
        nodeQueue.Enqueue(root);
        
        while (nodeQueue.Count > 0)
        {
            var size = nodeQueue.Count;
            
            // Iterate thru all nodes on current level
            for (var i = 0; i < size; i++)
            {
                var curr = nodeQueue.Dequeue();
                
                // Imporant to check we don't point next pointer beyond the end of current level
                if (i < size - 1)
                {
                    curr.next = nodeQueue.Peek();
                }
                
                if (curr.left != null)
                {
                    nodeQueue.Enqueue(curr.left);
                }
                
                if (curr.right != null)
                {
                    nodeQueue.Enqueue(curr.right);
                }
            }
        }
        
        return root;
    }
}