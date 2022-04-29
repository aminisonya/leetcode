public class Solution {
    public string MinWindow(string s, string t) {
        // Sliding window approach
        // Use dict for chars from t (smaller string)
        // Slide thru s, searching for all chars from t
        // Keep track of each window size, updating for MIN window size each time valid window is found
        // Window expands to the right when window isn't valid. When window is valid, contract left side until no longer valid.
        
        var dict = new Dictionary<char, int>(); // char as key : number of occurrences as value
        for (var i = 0; i < t.Length; i++)
        {
            if (!dict.ContainsKey(t[i]))
            {
                dict.Add(t[i], 1);
            }
            else
            {
                dict[t[i]]++;
            }            
        }
        var counter = dict.Count;
        
        var minSize = Int32.MaxValue;
        var strIndexes = new int[2];
        var left = 0;
        var right = 0;
        var answer = "";
        
        while (right < s.Length)
        {
            if (dict.ContainsKey(s[right]))
            {
                dict[s[right]]--;
                
                if (dict[s[right]] == 0)
                {
                    counter--;
                }
            }
            
            right++;
            
            while (counter == 0)
            {
                if (right - left < minSize)
                {
                    minSize = right - left;
                    strIndexes[0] = left;
                    strIndexes[1] = right;
                }
                
                if (dict.ContainsKey(s[left]))
                {
                    dict[s[left]]++;
                    
                    if (dict[s[left]] > 0)
                    {
                        counter++;
                    }
                }
                left++; 
            }
        }
        
        var strBuilder = new StringBuilder();
        for (var i = strIndexes[0]; i < strIndexes[1]; i++)
        {
            strBuilder.Append(s[i]);
        }
        
        return strBuilder.ToString();
    }
}