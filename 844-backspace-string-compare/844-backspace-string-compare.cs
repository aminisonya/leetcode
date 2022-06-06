public class Solution {
    public bool BackspaceCompare(string s, string t) {
        // Stimulate building a string while iterating backwards thru the two strings
        // Skip next char when '#' char comes up
        // Two pointer approach to iterate thru both strings at once
        // Compare both string's chars at each iteration
        
        var i = s.Length - 1;
        var j = t.Length - 1;
        var skipS = 0;
        var skipT = 0;
        
        while (i >= 0 || j >= 0)
        {
            while (i >= 0)
            {
                if (s[i] == '#')
                {
                    skipS++;
                    i--;
                }
                else if (skipS > 0)
                {
                    skipS--;
                    i--;
                }
                else
                {
                    break;
                }
            }
            while (j >= 0)
            {
                if (t[j] == '#')
                {
                    skipT++;
                    j--;
                }
                else if (skipT > 0)
                {
                    skipT--;
                    j--;
                }
                else
                {
                    break;
                }
            }
            
            // Now compare to see if the two chars are the same
            // Make sure still in bounds for both strings
            if (i >= 0 && j >= 0 && s[i] != t[j])
            {
                return false;
            }
            
            // Check if BOTH strings still have chars left, or if BOTH strings are now empty (we've iterated thru all the chars already)
            if ((i >= 0) != (j >= 0))
            {
                return false;
            }
            
            i--;
            j--;
        }
        
        return true;
    }
}