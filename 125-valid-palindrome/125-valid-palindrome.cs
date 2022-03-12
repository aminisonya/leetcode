public class Solution {
    public bool IsPalindrome(string s) {
        // Two pointers
        // Traverse inwards from both ends
        // Ignore non-alphanumeric chars
        
        var i = 0;
        var j = s.Length - 1;
        
        while (i < j)
        {
            if (!Char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            
            if (!Char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }
            
            if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
            {
                return false;
            }
            
            i++;
            j--;
        }
        
        return true;
    }
}