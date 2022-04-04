public class Solution {
    public bool ValidPalindrome(string s) {
        // Two pointer approach, moving inwards from both ends
        // Check if same char
        // If not, try both possibilities, seeing if valid palindrome can exist from skipping one char with either left or right pointer
        
        var left = 0;
        var right = s.Length - 1;
        
        while (left < right)
        {
            if (s[left] != s[right])
            {
                if (Valid(s, left + 1, right) || Valid(s, left, right - 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                left++;
                right--;
            }
        }
        
        return true;
    }
    
    public bool Valid(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
            else
            {
                i++;
                j--;
            }
        }
        
        return true;
    }
}