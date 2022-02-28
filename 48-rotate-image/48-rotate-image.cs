public class Solution {
    public void Rotate(int[][] matrix) {
        Transpose(matrix);
		Reflect(matrix);
    }
	
	public void Transpose(int[][] matrix)
	{
		var n = matrix.Length;
		
		for (var i = 0; i < n; i++)
		{
			for (var j = i + 1; j < n; j++)
			{
				var temp = matrix[j][i];
				matrix[j][i] = matrix[i][j];
				matrix[i][j] = temp;
			}
		}
	}
	
	public void Reflect(int[][] matrix)
	{
		var n = matrix.Length;
		
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n / 2; j++)
			{
				var temp = matrix[i][j];
				matrix[i][j] = matrix[i][n - j - 1];
				matrix[i][n - j - 1] = temp;
			}
		}
	}
}