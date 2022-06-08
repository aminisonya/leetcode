public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Vertical scanning approach
        // Iterate thru chars in first word
        // Inner loop to iterate thru the rest of the words in array, comparing current chars until a mismatch is found
        
        // Outer loop to iterate thru chars in first word
        for (var i = 0; i < strs[0].Length; i++)
        {
            var curr = strs[0][i];
            
            // Inner loop to iterate thru rest of words in array
            // Compare char in next words with the char from first word
            for (var j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || curr != strs[j][i])
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        
        return strs[0];
    }
}