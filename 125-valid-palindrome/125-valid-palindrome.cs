public class Solution {
    public bool IsPalindrome(string s) {
        // two pointers
        // traverse invwards from outer ends of string
        // compare each char that is a letter or digit
        
        var left = 0;
        var right = s.Length - 1;
        var lowerS = s.ToLower();
        
        while (left < right)
        {
            if (!Char.IsLetterOrDigit(lowerS[left])) {
                left++;
                continue;
            } else if (!Char.IsLetterOrDigit(lowerS[right])) {
                right--;
                continue;
            } else {
                if (lowerS[left] != lowerS[right]) {
                    return false;
                }
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}