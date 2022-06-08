public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        // BFS + Queue + Hashset for visited cells
        // Start by enqueueing all cells with 0's
        // Check their neighbors, update value with distance from 0 for each cell
        // Keep track of distance for each iteration round thru queue contents
        
        var rows = mat.Length;
        var cols = mat[0].Length;
        var queue = new Queue<(int, int)>(); // Tuple within queue
        var visited = new HashSet<(int, int)>();
        
        // Add all cells with 0s to queue and visited list
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                    visited.Add((i, j));
                }
            }
        }
        
        // Directions to loop thru for each cell
        var r = new int[] { 0, 1, 0, -1 };
        var c = new int[] { 1, 0, -1, 0 };
        var distance = 0;
        
        while (queue.Count > 0)
        {
            var size = queue.Count;
            distance++;
            
            while (size > 0)
            {
                // decrement size as we iterate thru queue contents
                // Don't want to iterate thru next level of queue contents in this round
                size--;
                
                var curr = queue.Dequeue();
                
                // Iterate thru all 4 neighbors
                for (var d = 0; d < 4; d++)
                {
                    var n1 = curr.Item1 + r[d];
                    var n2 = curr.Item2 + c[d];
                    
                    // Check to make sure still in bounds of matrix and that cell hasn't been visited already
                    if (n1 < 0 || n2 < 0 || n1 >= rows || n2 >= cols || visited.Contains((n1, n2)))
                    {
                        // If so, do nothing and move on to next neighbor cell
                        continue;
                    }
                    
                    // Update cell value with distance! And add to queue and hashset
                    mat[n1][n2] = distance;
                    queue.Enqueue((n1, n2));
                    visited.Add((n1, n2));
                }
            }
        }
        
        return mat;
    }
}