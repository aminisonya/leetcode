public class Solution {
    public bool Exist(char[][] board, string word) {
        // Backtracking recursion
        // If next letter is not next letter in word we're searching for, backtrack
        // Traverse matrix starting from top left
        // As we traverse, want to mark visited cells somehow
        
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (Backtrack(board, i, j, 0, word))
                {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public bool Backtrack(char[][] board, int row, int col, int index, string word)
    {
        // Check if we have surpassed letters in word, that means we've found the word
        if (index >= word.Length)
        {
            return true;
        }
        
        // Check if we are out of bounds of matrix
        if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length)
        {
            return false;
        }
        
        // Check if current place in board is equal to next letter in word we're searching for
        if (board[row][col] != word[index])
        {
            return false;
        }
        
        // Mark current place in board so as not to doubly visit it
        // Keep hold of value in temp variable in case it doesn't work out
        var temp = board[row][col];
        board[row][col] = '#';        
        
        var result = false;
        
        // Want to go in clockwise order, checking next candidates
        var rowsToCheck = new int[4] {1, 0, -1, 0};
        var colsToCheck = new int[4] {0, 1, 0, -1};
        
        for (var i = 0; i < 4; i++)
        {
            result = Backtrack(board, row + rowsToCheck[i], col + colsToCheck[i], index + 1, word);
            
            if (result == true)
            {
                break;
            }
        }
        
        // If wasn't valid move, change letter back to letter from '#' placeholder
        board[row][col] = temp;
        return result;
    }
}