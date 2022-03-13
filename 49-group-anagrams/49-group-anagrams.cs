public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        
        if (strs.Length < 1)
        {
            return result;
        }
        
        var dict = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            var chars = str.ToCharArray();
            Array.Sort(chars);
            var sortedStr = new string(chars);
            
            if (!dict.ContainsKey(sortedStr))
            {
                dict.Add(sortedStr, new List<string>());
            }
            
            dict[sortedStr].Add(str);
        }
        
        foreach (var item in dict.Keys)
        {
            result.Add(dict[item]);
        }
        
        return result;
    }
}