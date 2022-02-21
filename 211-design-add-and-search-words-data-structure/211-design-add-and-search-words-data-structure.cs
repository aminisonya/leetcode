    public class TrieNode {
		public Dictionary<char, TrieNode> children;
		public bool isWord;
		
		public TrieNode() {
			this.children = new Dictionary<char, TrieNode>();
			this.isWord = false;
		}
	}
	
	public class WordDictionary {
		public TrieNode root;

		public WordDictionary() {
			root = new TrieNode();
		}

		public void AddWord(string word) {
			var curr = root;
			for (var i = 0; i < word.Length; i++) {
				if (!curr.children.ContainsKey(word[i])) {
					curr.children.Add(word[i], new TrieNode());
				}
				curr = curr.children[word[i]];
			}
			curr.isWord = true;
		}

		public bool Search(string word) {
			//want to use recursion to search ALL possibilites when char = '.'
			return SearchInWord(word, root);
		}
		
		public bool SearchInWord(string word, TrieNode root) {
			//loop through letters in children, searching for each letter in word
			//if letter isn't there but IS '.' search recursively thru all possibilities
			for (var i = 0; i < word.Length; i++) {
				var curr = word[i];
				if (!root.children.ContainsKey(curr)) {
					if (curr == '.') {
						foreach (char c in root.children.Keys) {
							var child = root.children[c];
							if (SearchInWord(word.Substring(i + 1), child)) {
								return true;
							}
						}
					}
					return false;
				} else {
					root = root.children[curr];
				}
			}
			return root.isWord;
		}
	}