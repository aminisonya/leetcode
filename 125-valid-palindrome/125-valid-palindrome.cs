public class Solution {
    public bool IsPalindrome(string s) {
        // iterate inwards from outter ends
        // skip non-alphanumeric chars and spaces
        // how to compare uppercase and lowercase letters???
        // return false if find a mismatch
        
        var left = 0;
        var right = s.Length - 1;
        
        while (left < right)
        {
            if (left < s.Length && !Char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            
            if (right >= 0 && !Char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            
            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}