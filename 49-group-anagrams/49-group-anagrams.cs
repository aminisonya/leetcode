public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        
        if (strs.Length < 1)
        {
            return result;
        }
        
        // Create dictionary to store a character count string and a list for all strings that fit that character count
        var dict = new Dictionary<string, List<string>>();
        
        // Loop thru strings
        foreach (var str in strs)
        {
            // We want to keep count of how many times each char appears in each string
            var chars = str.ToCharArray();
            var charArr = new int[26];
            
            foreach (var c in chars)
            {
                // Subtract 'a' to get the ASCII number value for that character (for lowercase)
                var curr = c - 'a';
                charArr[curr]++;
            }
            
            // Translate the int array into a string to be used as a key in our dictionary later
            var sb = new StringBuilder();
            for (var i = 0; i < 26; i++)
            {
                sb.Append('#');
                sb.Append(charArr[i]);
            }
            var strKey = sb.ToString();
            
            // Add if it doesn't already exist in our dictionary
            if (!dict.ContainsKey(strKey))
            {
                dict.Add(strKey, new List<string>());
            }
            
            // Add the current string from our list of strings to the dictionary
            // All strings with the same character count will be added to the same key in the dict
            dict[strKey].Add(str);
        }
        
        // Loop thru dictionary and add all values to result set
        foreach (var item in dict.Keys)
        {
            result.Add(dict[item]);
        }
        
        return result;
    }
}