public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        
        if (p.Length > s.Length)
        {
            return result;
        }
        
        // Initialize two char arrays for each string
        // And values for starting window (length of p)
        var sChars = new int[26];
        var pChars = new int[26];
        for (var i = 0; i < p.Length; i++)
        {
            pChars[p[i] - 'a']++;
        }
                
        // Sliding window
        var left = 0;        
        for (var right = 0; right < s.Length; right++)
        {
            sChars[s[right] - 'a']++;
            
            if (right >= p.Length)
            {
                sChars[s[right - p.Length] - 'a']--;
            }
            
            if (IsEqual(sChars, pChars))
            {
                result.Add(right - p.Length + 1);
            }
        }
        
        return result;
    }
    
    private bool IsEqual(int[] one, int[] two)
    {
        for (var i = 0; i < one.Length; i++)
        {
            if (one[i] != two[i])
            {
                return false;
            }
        }
        return true;
    }
}