public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        // Want to traverse the entire grid
        // Keep count of biggest island so far and update this as we go
        // Follow a DFS pattern to check island sizes
        // If 1, keep searching neighbors
        // Want to mark visited 1's so we don't have duplication
        // Make sure to stay in bounds of grid
        
        var maxArea = 0;
        
        for (var row = 0; row < grid.Length; row++)
        {
            for (var col = 0; col < grid[0].Length; col++)
            {
                var currMax = GetIslandArea(grid, row, col);
                maxArea = Math.Max(maxArea, currMax);
            }
        }
        
        return maxArea;
    }
    
    public int GetIslandArea(int[][] grid, int row, int col)
    {
        // Make sure we're in bounds
        if (row < 0 || col < 0 || row > grid.Length - 1 || col > grid[0].Length - 1)
        {
            return 0;
        }
        
        // Check if 1
        if (grid[row][col] != 1)
        {
            return 0;
        }
        
        // Mark current square as visited
        grid[row][col] = 2;
        
        // Check neighbors
        var rows = new int[4] {-1, 0, 1, 0};
        var cols = new int[4] {0, 1, 0, -1};
        var max = 1;
        
        for (var i = 0; i < 4; i++)
        {
            max = max + GetIslandArea(grid, row + rows[i], col + cols[i]);
        }
        
        // Return max area of this island
        return max;
    }
}