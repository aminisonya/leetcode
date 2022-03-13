public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        
        if (strs.Length < 1)
        {
            return result;
        }
        
        // Use a dictionary to store sorted string along with all unsorted strings that have the same sorted string value
        var dict = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            // Convert to character array and SORT character array
            var chars = str.ToCharArray();
            Array.Sort(chars);
            
            // Create new string from sorted character array
            var sortedStr = new string(chars);
            
            // If sorted string has not been added to dict yet, add it now
            if (!dict.ContainsKey(sortedStr))
            {
                dict.Add(sortedStr, new List<string>());
            }
            
            // Add original unsorted string to list of strings for that sorted string key
            dict[sortedStr].Add(str);
        }
        
        // Loop thru dict and add all values to our result set
        foreach (var key in dict.Keys)
        {
            result.Add(dict[key]);
        }
        
        return result;
    }
}