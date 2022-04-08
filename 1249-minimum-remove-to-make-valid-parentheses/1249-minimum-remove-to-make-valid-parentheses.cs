public class Solution {
    public string MinRemoveToMakeValid(string s) {
        // Loop thru string
        // Add indexes of ( parans to stack
        // If ) and if nothing in stack, add to hashset. If gone thru string and still ( remaining in stack, add indexes to hashset
        // Build result string by not including chars at indexes in hashset
        
        var stack = new Stack<int>();
        var hashset = new HashSet<int>();
        
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            
            if (c == '(')
            {
                stack.Push(i);
            }
            else if (c == ')')
            {
                if (stack.Count <= 0)
                {
                    hashset.Add(i);
                }
                else
                {
                    stack.Pop();
                }
            }            
        }
        
        while (stack.Count > 0)
        {
            hashset.Add(stack.Pop());
        }
        
        var sb = new StringBuilder();
        
        for (var j = 0; j < s.Length; j++)
        {
            if (!hashset.Contains(j))
            {
                sb.Append(s[j]);
            }
        }
        
        return sb.ToString();
    }
}