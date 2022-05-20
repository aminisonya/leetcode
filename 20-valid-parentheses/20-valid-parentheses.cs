public class Solution {
    public bool IsValid(string s) {
        // Use a Stack
        // If else chain statements
        // Add open brackets to stack
        // when see a close bracket check stack for matching open bracket, pop it off stack or return false
        
        var stack = new Stack<char>();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count <= 0)
                {
                    return false;
                }
                
                var curr = stack.Pop();
                
                if (s[i] == ')' && curr != '(')
                {
                    return false;
                }
                else if (s[i] == '}' && curr != '{')
                {
                    return false;
                }
                else if (s[i] == ']' && curr != '[')
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0 ? true : false;
    }
}