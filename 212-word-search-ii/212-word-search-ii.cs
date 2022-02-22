public class Solution {
    public class TrieNode
        {
            public TrieNode[] Next = new TrieNode[26];
            public String Word { get; set; }  // it is word, a string from root node to current char

            public TrieNode Build(String[] words)
            {
                TrieNode root = new TrieNode();

                foreach (var word in words)
                {
                    var trie = root;
                    foreach (var c in word.ToCharArray())
                    {
                        int current = c - 'a';

                        if (trie.Next[current] == null)
                        {
                            trie.Next[current] = new TrieNode();
                        }

                        trie = trie.Next[current]; // iterate to next 
                    }

                    // reach the leaf node of trie - add word string
                    trie.Word = word;
                }

                return root;
            }

            public bool IsWord()
            {
                return Word != null; 
            }

            public void DeDuplicate()
            {
                Word = null; 
            }
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {
            var set = new HashSet<string>();
            var trie = new TrieNode();

            var root = trie.Build(words); ;

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    applyDFS(board, row, col, root, set);
                }
            }

            return set.ToList();
        }

        private static void applyDFS(char[][] board, int row, int column, TrieNode trie, HashSet<String> found)
        {
            // current char to visit           
            var visit = board[row][column];

            // skip visited ones
            if (visit == '#' || trie.Next[visit - 'a'] == null)
            {
                return;
            }

            trie = trie.Next[visit - 'a'];

            if (trie.IsWord())  // the word is found, need to add to result 
            {
                found.Add(trie.Word);                
            }

            // mark visited
            board[row][column] = '#'; // mark the node value with '#', so it will not match any char

            // up, left, down, right four directions
            var rows = board.Length;
            var columns = board[0].Length;

            if (row > 0)
            {
                applyDFS(board, row - 1, column, trie, found);
            }

            if (column > 0)
            {
                applyDFS(board, row, column - 1, trie, found);
            }

            if (row < rows - 1)
            {
                applyDFS(board, row + 1, column, trie, found);
            }

            if (column < columns - 1)
            {
                applyDFS(board, row, column + 1, trie, found);
            }

            // depth first search - backtracking 
            board[row][column] = visit; 
        }
}