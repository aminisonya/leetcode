public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Loop thru strings array
        // Vertical scanning approach
        
        if (strs == null || strs.Length == 0)
        {
            return "";
        }
        
        // Outer loop going thru chars in first string
        for (var i = 0; i < strs[0].Length; i++)
        {
            var c = strs[0][i];
            
            // Inner loop going thru words array
            // Comparing each word to the first word, char by char
            for (var j = 1; j < strs.Length; j++)
            {
                // Check we're still in bounds of next word
                // Check if char matches current char
                if (i == strs[j].Length || strs[j][i] != c)
                {
                    // Can return substring as soon as mismatch is found
                    // That would be the longest common prefix
                    return strs[0].Substring(0, i);
                }
            }
        }
        
        return strs[0];
    }
}