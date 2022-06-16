public class Trie {
    public TrieNode root;

    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        var curr = root;
        
        for (var i = 0; i < word.Length; i++)
        {
            // id to represent current char
            var id = word[i] - 'a';
            
            // if that char doesn't exist yet in children, create a node there
            // then set curr to next char
            if (curr.children[id] == null)
            {
                curr.children[id] = new TrieNode();
            }
            curr = curr.children[id];
        }
        
        // Mark last letter as the end of the word
        curr.isEnd = true;
    }
    
    public bool Search(string word) {
        var curr = root;
        
        for (var i = 0; i < word.Length; i++)
        {
            // iterate to next letter in word
            curr = curr.children[word[i] - 'a'];
            
            // if letter doesn't exist, return false
            if (curr == null)
            {
                return false;
            }
        }
        
        return curr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        var curr = root;
        
        for (var i = 0; i < prefix.Length; i++)
        {
            curr = curr.children[prefix[i] - 'a'];
            
            if (curr == null)
            {
                return false;
            }
        }
        
        return true;
    }
}

public class TrieNode
{
    public bool isEnd;
    public TrieNode[] children;
    
    public TrieNode()
    {
        children = new TrieNode[26];
        isEnd = false;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */