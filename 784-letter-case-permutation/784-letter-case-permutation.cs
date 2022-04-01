public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        // Each letter has two possible permutations, lowercase and uppercase
        // Can skip ints, no permutation possible
        // Iterate thru chars in string, for each char we add two versions of that to final output
        var result = new List<string>();
        
        if (s.Length <= 0)
        {
            return result;
        }
        
        result.Add(s);
        
        // Call recursive function to create permutations
        Permutate(s.ToCharArray(), 0, result);
        
        return result;
    }
    
    public void Permutate(char[] str, int index, List<string> result)
    {
        // Have we already gone thru all of the string? then simply return
        if (index >= str.Length)
        {
            return;
        }
        
        // Recurse
        Permutate(str, index + 1, result);
        
        // Get current char
        var orig = str[index];
        
        // If current char is NOT a digit, it's a letter
        if (!char.IsDigit(orig))
        {
            // Check if was lowercase already
            if (orig >= 'a' && orig <= 'z')
            {
                // If it was lowercase, change to uppercase
                str[index] = char.ToUpper(orig);
            }
            else
            {
                // If it was uppercase, change to lowercase
                str[index] = char.ToLower(orig);
            }
            
            // Add this new char array, converted to a string, to our result list
            result.Add(new string(str));
            // Recurse
            Permutate(str, index + 1, result);
            // Change char back to what it originally was
            str[index] = orig;
        }
    }
}