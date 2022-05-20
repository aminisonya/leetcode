public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        // Change current square's value if matches original color value
        // Go in order to search for next possible square to change (up right down left)
        // Recursion on neighboring pixels
        // Base case: make sure are in bounds still
        
        var oldColor = image[sr][sc];
        if (oldColor != newColor)
        {
            ChangeColor(image, sr, sc, oldColor, newColor);
        }
        return image;      
    }
    
    public void ChangeColor(int[][] image, int row, int col, int oldColor, int newColor)
    {
        // Check if we're in bounds of array
        if (row < 0 || row > image.Length - 1 || col < 0 || col > image[0].Length - 1)
        {
            return;
        }
        
        // Check if color needs to be changed
        if (image[row][col] != oldColor)
        {
            return;
        }
        
        // Update current color
        image[row][col] = newColor;
        
        // If does need to be updated, DFS on neighbors
        var rows = new int[4] {0,0,1,-1};
        var cols = new int[4] {1,-1,0,0};
        
        for (var i = 0; i < 4; i++)
        {
            ChangeColor(image, row + rows[i], col + cols[i], oldColor, newColor);
        }
    }
}