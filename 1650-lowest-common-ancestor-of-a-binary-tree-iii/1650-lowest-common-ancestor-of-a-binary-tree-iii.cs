/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {
        // Use a hashset to store values of nodes on path from p to root
        // Traverse from q to root, checking for first match with hashset
        // That first match will be the LCA
        
        var hashset = new HashSet<int>();
        
        while (p != null)
        {
            hashset.Add(p.val);
            p = p.parent;
        }
        
        while (q != null)
        {
            if (hashset.Contains(q.val))
            {
                return q;
            }
            
            q = q.parent;
        }
        
        return new Node(0);
    }
}