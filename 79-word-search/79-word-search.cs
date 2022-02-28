public class Solution {
    public bool Exist(char[][] board, string word) {
    for (var i = 0; i < board.Length; i++)
    {
      for (var j = 0; j < board[i].Length; j++)
      {
        // Backtracking
        if (Backtrack(board, i, j, word, 0))
        {
          return true;
        }
      }
    }
    
    return false;
  }

  public bool Backtrack(char[][] board, int row, int col, string word, int index)
  {
    // Have we found all letters in the word?
    if (index >= word.Length)
    {
      return true;
    }

    // FIRST ensure we aren't out of bounds of board
    // Then check if current letter matches place in word
    if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] != word[index])
    {
      return false;
    }

    // Mark current place
    // Search all directions 
    board[row][col] = '#';

    var rowOffsets = new int[] {0, 1, 0, -1};
    var colOffsets = new int[] {1, 0, -1, 0};
    for (var i = 0; i < 4; i++)
    {
      if (Backtrack(board, row + rowOffsets[i], col + colOffsets[i], word, index + 1)) 
      {
        return true;
      }
    }

    board[row][col] = word[index];
    return false;
  }
}