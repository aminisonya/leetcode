public class Solution {
    public bool IsAnagram(string s, string t) {
        // dictionary or char array approach
        // loop thru s, build up char array and use count variable to keep track of matches
        // if find a mismatch, return false
        
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var charArr = new int[26];
        var count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            charArr[s[i] - 'a']++;
            count++;
        }
        
        for (var i = 0; i < t.Length; i++)
        {
            if (charArr[t[i] - 'a'] <= 0)
            {
                return false;
            }
            else
            {
                charArr[t[i] - 'a']--;
                count--;
            }
        }
        
        return (count == 0);
    }
}