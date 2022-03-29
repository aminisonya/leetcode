public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        // Traverse entire matrix + Create new matrix with values of distance
        // Use DP, split into two passes of matrix
        // Can use prev calculated distances of neighbor cells to calculate current distance
        // Need to check all 4 directions, split this into two: top/left and bottom/right
        
        if (mat == null || mat.Length == 0)
        {
            return mat;
        }
        
        var result = new int[mat.Length][];
        
        // First pass: check for left and top
        for (var row = 0; row < mat.Length; row++)
        {
            result[row] = new int[mat[row].Length];
            
            for (var col = 0; col < result[row].Length; col++)
            {
                result[row][col] = Int32.MaxValue - 100000;
                
                if (mat[row][col] == 0)
                {
                    result[row][col] = 0;
                }
                else
                {
                    if (row > 0)
                    {
                        result[row][col] = Math.Min(result[row][col], result[row - 1][col] + 1);
                    }
                    if (col > 0)
                    {
                        result[row][col] = Math.Min(result[row][col], result[row][col - 1] + 1);
                    }
                }
            }
        }
        
        // Second pass: check for bottom and right
        for (var i = mat.Length - 1; i >= 0; i--)
        {
            for (var j = mat[0].Length - 1; j >= 0; j--)
            {
                if (i < mat.Length - 1)
                {
                    result[i][j] = Math.Min(result[i][j], result[i + 1][j] + 1);
                }
                if (j < mat[0].Length - 1)
                {
                    result[i][j] = Math.Min(result[i][j], result[i][j + 1] + 1);
                }
            }
        }
        
        return result;
    }
}