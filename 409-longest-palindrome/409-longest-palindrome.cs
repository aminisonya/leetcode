public class Solution {
    public int LongestPalindrome(string s) {
        // Includes both lowercase and uppercase chars. Case sensitive.
        // Use hashset to keep count of repeated and non repeated chars
        // If exists in hashet, you know you have 2 of that char and therefore 2 more letters to build a palindrome
        // If doesn't exist in hashset, add it to hashset
        // After looping thru all chars, if there is anything left in hashset, that means there are unique chars and we can add ONE to our count of longest palindrome to return
        
        var hashset = new HashSet<char>();
        var longestPal = 0;
        
        foreach (var ch in s)
        {
            if (hashset.Contains(ch))
            {
                longestPal += 2;
                hashset.Remove(ch);
            }
            else
            {
                hashset.Add(ch);
            }
        }
        
        return hashset.Count > 0 ? longestPal + 1 : longestPal;
    }
}