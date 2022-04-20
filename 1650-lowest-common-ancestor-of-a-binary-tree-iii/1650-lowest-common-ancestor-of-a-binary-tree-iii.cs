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
    public Node LowestCommonAncestor(Node p, Node q)
    {
        // Find heights of both nodes
        // Start from lower node, iterate upwards until at same height as higher node
        // Once at equal height, iterate upwards until find a match
        
        var height1 = FindHeight(p);
        var height2 = FindHeight(q);
        
        // For simplicity, always set lower node as p
        if (height1 < height2)
        {
            var temp = p;
            p = q;
            q = temp;
        }
        
        var heightDiff = Math.Abs(height1 - height2);
        while (heightDiff > 0)
        {
            p = p.parent;
            heightDiff--;
        }
        
        while (p != q)
        {
            p = p.parent;
            q = q.parent;
        }
        
        return p;
    }
    
    public int FindHeight(Node node)
    {
        var height = 0;
        
        while (node != null)
        {
            height++;
            node = node.parent;
        }
        
        return height;
    }
}
//     public Node LowestCommonAncestor(Node p, Node q) {
// ----------------- Optimal Solution Option -----------------
    
//         //Treat problem same as two linked lists
//         //Find where they intersect
//         //Create a "cycle" by interlooping the two paths from each node
        
//         var runner1 = p;
//         var runner2 = q;
        
//         while (runner1 != runner2)
//         {
//             runner1 = (runner1.parent == null) ? q : runner1.parent;
//             runner2 = (runner2.parent == null) ? p : runner2.parent;
//         }
        
//         return runner1;
    
// ----------------- Suboptimal Solution -----------------
    
//         // Use a hashset to store values of nodes on path from p to root
//         // Traverse from q to root, checking for first match with hashset
//         // That first match will be the LCA
        
//         var hashset = new HashSet<int>();
        
//         while (p != null)
//         {
//             hashset.Add(p.val);
//             p = p.parent;
//         }
        
//         while (q != null)
//         {
//             if (hashset.Contains(q.val))
//             {
//                 return q;
//             }
            
//             q = q.parent;
//         }
        
//         return new Node(0);
//     }