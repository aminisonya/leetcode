public class Solution {
    public int OrangesRotting(int[][] grid) {
        // Graph + BFS + Queue
        // Keep track of minutes (levels of queue needed to iterate thru)
        // Count number of fresh oranges at beginning, make sure it's 0 at the end otherwise return -1
        
        var queue = new Queue<(int, int)>();
        var fresh = 0;
        var mins = 0;
        
        // Initiate count of fresh oranges and enqueue all rotten oranges
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                }
                else if (grid[i][j] == 1)
                {
                    fresh++;
                }
            }
        }
        
        if (fresh == 0) return 0;
        
        var rows = new int[] { 0, 1, 0, -1};
        var cols = new int[] { 1, 0, -1, 0};
        
        while (queue.Count > 0)
        {
            var size = queue.Count;
            
            for (var i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                
                for (var d = 0; d < 4; d++)
                {
                    var r = curr.Item1 + rows[d];
                    var c = curr.Item2 + cols[d];
                    
                    if (r >= 0 && c >= 0 && r < grid.Length && c < grid[0].Length
                       && grid[r][c] == 1)
                    {
                        grid[r][c] = 2;
                        fresh--;
                        queue.Enqueue((r, c));
                    }
                }
            }
            
            mins++;
        }
        
        // Subtract from mins, as last loop will add 1 unnecessarily 
        return fresh == 0 ? mins - 1 : -1;
    }
}