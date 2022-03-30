public class Solution {
    public int OrangesRotting(int[][] grid) {
        // Traverse the whole grid, add rotten oranges to queue and keep count of fresh oranges
        // Go thru queue of rotten oranges, for each rotten orange traverse in all 4 directions
        // If see fresh orange, change to rotten orange, and add to queue, and decrement count of fresh oranges
        // Return number of times queue was traversed until empty (number of mins for all oranges to go rotten)
        
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }
        
        var rows = grid.Length;
        var cols = grid[0].Length;
        var queue = new Queue<(int, int)>(); // Queue of Tuples with row and col indexes for each rotten orange
        var freshOranges = 0;
        
        // Traverse grid, enqueue all rotten oranges and keep count of fresh oranges
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                }
                else if (grid[i][j] == 1)
                {
                    freshOranges++;
                }
            }
        }
        
        // If there were no fresh oranges, simply return 0
        if (freshOranges == 0)
        {
            return 0;
        }
        
        var mins = 0;
        // Rows and cols arrays to traverse all 4 directions from each cell
        var drows = new int[] {1, -1, 0, 0};
        var dcols = new int[] {0, 0, 1, -1};
        
        // Loop thru queue
        while (queue.Count > 0)
        {
            // Keep track of "minutes"/each traversal to new row/col
            mins++;
            var size = queue.Count;
            
            // For every item currently in queue... (For every item in this level of BFS)
            for (var i = 0; i < size; i++)
            {
                var pair = queue.Dequeue();
                
                for (var j = 0; j < 4; j++)
                {
                    // Get next row/col vals
                    var r = pair.Item1 + drows[j];
                    var c = pair.Item2 + dcols[j];
                    
                    // Make sure we're not out of bounds
                    // Also, continue if not a fresh orange (do nothing if empty or rotten orange)
                    if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == 0 || grid[r][c] == 2)
                    {
                        continue;
                    }
                    
                    // Change to rotten orange value, add new rotten orange to queue
                    grid[r][c] = 2;
                    queue.Enqueue((r,c));
                    freshOranges--; // Decrement count of fresh oranges
                }
            }
        }
        
        // Subtract from mins, as last loop will add 1 unnecessarily 
        return freshOranges == 0 ? mins - 1 : -1;
    }
}