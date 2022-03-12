public class Solution {    
    public string LongestPalindrome(string s) {
        if (s == null || s.Length < 2)
        {
            return s;
        }
        
        var maxStart = 0;
        var maxEnd = 0;
        
        for (var i = 0; i < s.Length; i++)
        {
            var start = i;
            var end = i;
            
            // Get the longest palindrome from the centerpoint i (Odd length palindromes)
            while (start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])
            {
                start--;
                end++;
            }
            
            // If palindrome we just found is longer than our max, update max
            if (end - start > maxEnd - maxStart)
            {
                maxStart = start;
                maxEnd = end;
            }
            
            // Get longest palindrome from the centerpoint i and i + 1
            // For Even length palindromes
            if (i < s.Length - 1 && s[i] == s[i + 1])
            {
                start = i;
                end = i + 1;
                
                while (start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                
                // If this is longer than our max, update max
                if (end - start > maxEnd - maxStart)
                {
                    maxStart = start;
                    maxEnd = end;
                }
            }
        }
        
        // Since the second argument for Substring is desired length and not the endpoint
        // you have to add one to offset for zero-based indexing
        return s.Substring(maxStart, maxEnd - maxStart + 1);
    }
}