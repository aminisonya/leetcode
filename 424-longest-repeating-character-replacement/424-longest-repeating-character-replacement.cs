public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Sliding window
        // As we "slide", we need to know how many letters in our substring we need to replace
        // You take the size of the window minus the most frequent letter that is in that window
        // Once we know how many letters need to be replaced, we can compare it to given int "k" and adjust window if necessary
        
        // Array for all 26 letters
        var freq = new int[26];
        var left = 0;
        var max = 0;
        var mostFrequentLetter = 0;
        
        for (var right = 0; right < s.Length; right++)
        {
            freq[s[right] - 'A']++;
            mostFrequentLetter = Math.Max(mostFrequentLetter, freq[s[right] - 'A']);
            
            // As we "slide", we need to know how many letters in our substring we need to replace.
            // We do this by taking the size of the window minus the most frequent letter that is in that window.
            var lettersToReplace = (right - left + 1) - mostFrequentLetter;
            
            // Once we know how many letters need to be replaced, we can compare it to given int "k" and adjust window if necessary
            // If letters that need to be replaced is > k, we adjust our window
            if (lettersToReplace > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }
            
            // Get max between current window and previous max value
            max = Math.Max(max, (right - left + 1));    
        }
        
        return max;
    }
}