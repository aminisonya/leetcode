public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        // Find distance of nearest 0 for each cell
        // BFS + Queue
        // Queue will contain cells to be examined next
        // Add all cells with 0s to q
        // Pop cell from q, examine neighbors. If new distance for neighbor is smaller (orig set as int max), add to q.
        
        var rows = mat.Length;
        var cols = mat[0].Length;
        var result = new int[rows][];
        var queue = new Queue<(int, int)>();
        var visited = new HashSet<(int, int)>();
        
        // Enqueue all squares with 0's
        // Add those squares to visited hashset
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
        
        // Directions to iterate thru for each cell
        var r = new int[] { 0, 1, 0, -1 };
        var c = new int[] { 1, 0, -1, 0 };
        
        // level to keep track of distance from nearest 0
        var level = 0;
        while (queue.Count > 0)
        {
            var size = queue.Count;
            level++;
            
            while (size > 0)
            {
                size--;
                
                var curr = queue.Dequeue();
                
                for (var d = 0; d < 4; d++)
                {
                    var newi = curr.Item1 + r[d];
                    var newj = curr.Item2 + c[d];
                    
                    if (newi < 0 || newj < 0 || newi >= rows || newj >= cols || visited.Contains((newi, newj)))
                    {
                        continue;
                    }
                    
                    // Set distance (level) of current cell from nearest 0
                    // And add to queue and visited hashset
                    queue.Enqueue((newi, newj));
                    visited.Add((newi, newj));
                    mat[newi][newj] = level;
                }
            }
        }
        
        return mat;
    }
}