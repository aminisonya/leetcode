public class Solution {
    public bool IsAnagram(string s, string t) {
        // Build dictionary of chars from "s" + times it appears
        // Loop thru "t" and check if all characters are in "s"
        // If any remaining chars weren't used, return false
        
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var dict = new Dictionary<char, int>();
        
        foreach (var cha in s)
        {
            if (!dict.ContainsKey(cha))
            {
                dict.Add(cha, 1);
            }
            else
            {
                dict[cha]++;
            }
        }
        
        foreach (var cha in t)
        {
            if (!dict.ContainsKey(cha) || dict[cha] == 0)
            {
                return false;
            }
            dict[cha]--;
        }
        
        return true;
    }
}