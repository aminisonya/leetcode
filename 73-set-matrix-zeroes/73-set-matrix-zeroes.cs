public class Solution {
    public void SetZeroes(int[][] matrix) {
        // Iterate through matrix, searching for 0
		// If find a 0, update the FIRST value in that row/column to 0, to mark that row/column
		// Iterate through matrix again. If first value in a row or column is 0, change all values in that respective row/col to 0
        // Have separate vars for matrix[0][0], to see if that row or column should be 0s or not
		var firstCol = false;
		var firstRow = false;
		var rows = matrix.Length;
		var cols = matrix[0].Length;
		
		for (var i = 0; i < rows; i ++)
		{
			for (var j = 0; j < cols; j++)
			{
				if (matrix[i][j] == 0)
				{
					matrix[i][0] = 0;
					matrix[0][j] = 0;
					
					if (i == 0)
					{
						firstRow = true;
					}
					if (j == 0)
					{
						firstCol = true;
					}
				}
			}
		}
		
		for (var i = 1; i < rows; i++)
		{
			for (var j = 1; j < cols; j++)
			{
				if (matrix[i][0] == 0 || matrix[0][j] == 0)
				{
					matrix[i][j] = 0;
				}
			}
		}
		
		if (firstRow == true)
		{
			for (var j = 0; j < cols; j++)
			{
				matrix[0][j] = 0;
			}
		}
		
		if (firstCol == true)
		{
			for (var i = 0; i < rows; i++)
			{
				matrix[i][0] = 0;
			}
		}
    }
}