public class Solution {
    public int NumIslands(char[][] grid) {
        // Graph problem. BFS + Queue.
        // Keep track of visited nodes
        // Traverse all 4 directions to expand each island
        // Keep count of number of islands found
        
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }
        
        var visited = new HashSet<(int, int)>(); // visited cells, don't want to re-visit any
        var islands = 0;
        
        // Traverse the grid
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1' && !visited.Contains((i, j)))
                {
                    // do BFS
                    IslandSearch(grid, i, j, visited);
                    
                    // iterate island count
                    islands++;
                }
            }
        }
        
        return islands;
    }
    
    private void IslandSearch(char[][] grid, int row, int col, HashSet<(int, int)> visited)
    {
        var queue = new Queue<(int, int)>(); // queue of cells to visit and expand search of island on
        var rows = new int[] { 0, 1, 0, -1 };
        var cols = new int[] { 1, 0, -1, 0 };
        
        // Mark current cell as visited and add to queue for island
        visited.Add((row, col));
        queue.Enqueue((row, col));
        
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            // Search all 4 neighbors (vertical and horizontal only, no diagonal) to expand island or not
            for (var d = 0; d < 4; d++)
            {
                var r = curr.Item1 + rows[d];
                var c = curr.Item2 + cols[d];
                
                // Check to make sure still in bounds
                // And hasn't been visited already
                if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && !visited.Contains((r, c))
                   && grid[r][c] == '1')
                {
                    queue.Enqueue((r, c));
                    visited.Add((r, c));
                }
            }
        }
    }
}