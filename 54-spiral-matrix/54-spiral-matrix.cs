public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        // Set up boundaries
		var rows = matrix.Length;
		var cols = matrix[0].Length;
        var upperB = 0;
		var rightB = cols - 1;
		var lowerB = rows - 1;
		var leftB = 0;
		
		var result = new List<int>();
		
		while (result.Count < rows * cols)
		{
			// Left to right
			for (var col = leftB; col <= rightB; col++)
			{
				result.Add(matrix[upperB][col]);
			}
			
			// Top to bottom (upper to lower)
			for (var row = upperB + 1; row <= lowerB; row++)
			{
				result.Add(matrix[row][rightB]);
			}
			
			if (upperB != lowerB)
			{
				// Right to left
				for (var col = rightB - 1; col >= leftB; col--)
				{
					result.Add(matrix[lowerB][col]);
				}
			}
			
			if (leftB != rightB)
			{
				// Bottom to top (lower to upper)
				for(var row = lowerB - 1; row > upperB; row--)
				{
					result.Add(matrix[row][leftB]);
				}
			}
			
			upperB++;
			rightB--;
			lowerB--;
			leftB++;
		}
		
		return result;
    }
}