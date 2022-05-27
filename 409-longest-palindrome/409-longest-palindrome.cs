public class Solution {
    public int LongestPalindrome(string s) {
        // Includes both lowercase and uppercase chars. Case sensitive.
        // Can still use minus 'a' to see if they're equal chars or not
        // Keep count of unique chars and repeated chars
        // Sum of repeated chars / 2 plus one unique char (if any)
        
        var length = 0;
        var hashset = new HashSet<char>();
        foreach (char c in s)
        {
            if (hashset.Contains(c))
            {
                length += 2;
                hashset.Remove(c);
            }
            else
            {
                hashset.Add(c);
            }
        }
        
        return hashset.Count > 0 ? length + 1 : length;
    }
}