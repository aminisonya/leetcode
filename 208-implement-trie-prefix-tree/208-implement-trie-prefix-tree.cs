    public class TrieNode {
		public bool isEnd;
		public TrieNode[] children;
		
		public TrieNode() {
			children = new TrieNode[26];
			isEnd = false;
		}
	}
	
	public class Trie {
		private TrieNode root;
		
		public Trie() {
			root = new TrieNode();
		}
		
		private TrieNode GetNode(string word)
		{
			var curr = root;
			var i = 0;
			
			while (i < word.Length)
			{
				curr = curr.children[word[i] - 'a'];
				i++;
				if (curr == null) return null;
			}
			
			return curr;
		}

		public void Insert(string word) {
			var curr = root;
			
			for (var i = 0; i < word.Length; i++)
			{
				var id = word[i] - 'a';
				if (curr.children[id] == null)
				{
					curr.children[id] = new TrieNode();
				}
				curr = curr.children[id];
			}
			
			curr.isEnd = true;
		}

		public bool Search(string word) {
			var node = GetNode(word);
			return node != null && node.isEnd;
		}

		public bool StartsWith(string prefix) {
			var node = GetNode(prefix);
			return node != null;
		}
	}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */