public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Sliding window method
        // Use dictionary to keep track of current chars in window
        // When you see a repeating char, remove from dictionary and update/slide window
        
        var dict = new Dictionary<char, char>();
        var left = 0;
        var right = 0;
        var result = 0;
        
        while (right < s.Length)
        {
            if (!dict.ContainsKey(s[right]))
            {
                // If it's not a repeating char
                // Add to dictionary of current chars
                // Iterate right side of window to expand
                dict.Add(s[right], s[right]);
                right++;
                result = Math.Max(result, right - left);
            }
            else
            {
                // If it IS a repeating character
                // Remove far left from dictionary of current chars
                // Iterate left to adjust starting point of window
                dict.Remove(s[left]);
                left++;
            }
        }
        
        return result;
    }
}