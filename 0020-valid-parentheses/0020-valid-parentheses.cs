public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            var curr = s[i];

            if (curr == '(' || curr == '{' || curr == '[')
            {
                stack.Push(curr);
                continue;
            }
            
            char topOfStack;
            if (stack.Count > 0)
            {
                topOfStack = stack.Pop();
            }
            else
            {
                return false;
            }

            if (curr == ')' && topOfStack != '(' ||
                curr == '}' && topOfStack != '{' ||
                curr == ']' && topOfStack != '[')
            {
                return false;
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}