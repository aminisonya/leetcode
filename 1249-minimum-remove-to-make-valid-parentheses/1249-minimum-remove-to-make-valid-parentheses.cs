public class Solution {
    public string MinRemoveToMakeValid(string s) {
        // Loop thru string
        // Add indexes of ( parans to stack
        // If ) and if nothing in stack, add to hashset. If gone thru string and still ( remaining in stack, add indexes to hashset
        var indexesToRemove = new HashSet<int>();
        var stack = new Stack<int>();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                if (stack.Count <= 0)
                {
                    indexesToRemove.Add(i);
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        
        while (stack.Count > 0)
        {
            indexesToRemove.Add(stack.Pop());
        }
        
        var sb = new StringBuilder();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (!indexesToRemove.Contains(i))
            {
                sb.Append(s[i]);
            }
        }
        
        return sb.ToString();
    }
}