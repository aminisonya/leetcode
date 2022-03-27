public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        // Get color of first pixel to be changed
        // Search 4 neighboring pixels for that value
        // If same value, change to new value and search those 4 neighbors as well
        // Make sure to stay within bounds of matrix
        // Follow DFS strategy
        
        var oldColor = image[sr][sc];
        
        if (oldColor != newColor)
        {
            ReplaceOldColor(image, sr, sc, oldColor, newColor);
        }
        
        return image;
    }
    
    public void ReplaceOldColor(int[][] image, int row, int col, int oldColor, int newColor)
    {
        // Check if we're in bounds still
        if (row < 0 || col < 0 || row > image.Length - 1 || col > image[0].Length - 1)
        {
            return;
        }
        
        // Check if color needs to be updated
        if (image[row][col] != oldColor)
        {
            return;
        }
        
        // Update current color
        image[row][col] = newColor;
        
        // If does need to be updated, DFS on neighbors
        var rows = new int[4] {-1, 0, 1, 0};
        var cols = new int[4] {0, 1, 0, -1};
        
        for (var i = 0; i < 4; i++)
        {
            ReplaceOldColor(image, row + rows[i], col + cols[i], oldColor, newColor);
        }
    }
}