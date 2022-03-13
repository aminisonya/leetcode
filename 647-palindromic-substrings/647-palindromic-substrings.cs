public class Solution {
    public int CountSubstrings(string s) {
        if (s.Length < 2)
        {
            return s.Length;
        }
        
        var count = 0;
        
        for (var i = 0; i < s.Length; i++)
        {
            var left = i;
            var right = i;
            
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
                
                count++;
            }
            
            if (i < s.Length - 1)
            {
                left = i;
                right = i + 1;
                
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                    
                    count++;
                }
            }
        }
        
        return count;
    }
}