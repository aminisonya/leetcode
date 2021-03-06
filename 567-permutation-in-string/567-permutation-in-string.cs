public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // Sliding window
        // Iterater thru s1, store chars in array
        // Iterate thru s2 chars, check for chars from s1 string appearing consecutively
        // Return true if all chars from s1 found in a row in s2
        // Update window when char not in s1
        
        if (s1.Length > s2.Length)
        {
            return false;
        }
        
        var s1chars = new int[26];
        var s2chars = new int[26];
        for (var i = 0; i < s1.Length; i++)
        {
            s1chars[s1[i] - 'a']++;
            s2chars[s2[i] - 'a']++;
        }
        
        var count = 0;
        for (var i = 0; i < 26; i++)
        {
            if (s1chars[i] == s2chars[i])
            {
                count++;
            }
        }
        
        for (var i = 0; i < s2.Length - s1.Length; i++)
        {
            var l = s2[i] - 'a';
            var r = s2[i + s1.Length] - 'a';
            
            if (count == 26)
            {
                return true;
            }
            
            s2chars[r]++;
            if (s2chars[r] == s1chars[r])
            {
                count++;
            }
            else if (s2chars[r] == s1chars[r] + 1)
            {
                count--;
            }
            
            s2chars[l]--;
            if (s2chars[l] == s1chars[l])
            {
                count++;
            }
            else if (s2chars[l] == s1chars[l] - 1)
            {
                count--;
            }
        }
        
        return (count == 26);
    }
}