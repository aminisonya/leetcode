public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // use dict to keep track of CURRENT chars
        // sliding window
        
        var dict = new Dictionary<char, char>();
        var left = 0;
        var right = 0;
        var result = 0;
        
        while (right < s.Length)
        {
            if (!dict.ContainsKey(s[right]))
            {
                dict.Add(s[right], s[right]);
                right++;
                result = Math.Max(result, right - left);
            }
            else
            {
                dict.Remove(s[left]);
                left++;
            }
        }
        return result;
    }
}