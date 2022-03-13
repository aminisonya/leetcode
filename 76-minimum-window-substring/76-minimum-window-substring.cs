public class Solution {
    public string MinWindow(string s, string t) {
        // Sliding window
        
        if (s.Length == 0 || t.Length == 0)
        {
            return "";
        }
        
        // Create dictionary to keep track of unique characters in t, and count of each character
        var dictT = new Dictionary<char, int>();
        for (var i = 0; i < t.Length; i++)
        {
            if (!dictT.ContainsKey(t[i]))
            {
                dictT.Add(t[i], 1);
            }
            else
            {
                dictT[t[i]]++;
            }
        }
        
        // Initialize sliding window vars
        var counter = dictT.Count;
        var left = 0;
        var right = 0;
        var len = int.MaxValue; // This will keep track of our current minimum window
        
        var answer = "";
        
        // Sliding window
        while (right < s.Length)
        {
            var c = s[right];
            
            // If current char is found in t dict, decrement count
            if (dictT.ContainsKey(c))
            {
                dictT[c]--;
                if (dictT[c] == 0)
                {
                    // Once we've found all instances of a certain character in our window
                    // We can decrement our counter of unique letters
                    counter--;
                }
            }
            
            right++;
            
            // Once we've found a window with all characters from our substring...
            while (counter == 0)
            {
                // Update minimum window length and answer
                if (right - left < len)
                {
                    len = right - left;
                    answer = s.Substring(left, right - left);
                }
                
                var startChar = s[left];
                
                // After we've found a minimum substring
                // We adjust our left pointer to move on to find new possible min windows
                if (dictT.ContainsKey(startChar))
                {
                    dictT[startChar]++;
                    if (dictT[startChar] > 0)
                    {
                        counter++;
                    }
                }
                
                left++;
            }
        }
        
        return answer;
    }
}