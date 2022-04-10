public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        // Sliding window
        // Need to keep track of: curr longest substring, how many distinct chars so far, make sure they're less than k
        // Use a dictionary with char : frequency of char count
        
        if (k < 1 || s.Length < 1)
        {
            return 0;
        }
        
        var dict = new Dictionary<char, int>();
        var left = 0;
        var right = 0;
        var maxLength = 0;
        
        while (right < s.Length)
        {
            if (!dict.ContainsKey(s[right]))
            {
                dict.Add(s[right], 1);
            }
            else 
            {
                dict[s[right]]++;
            }
            
            while (dict.Count > k)
            {
                dict[s[left]]--;
                
                if (dict[s[left]] == 0)
                {
                    dict.Remove(s[left]);
                }
                
                left++;
            }
            
            right++;
            
            maxLength = Math.Max(maxLength, right - left);
        }
        
        return maxLength;
    }
}