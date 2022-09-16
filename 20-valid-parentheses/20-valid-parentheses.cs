public class Solution {
    public bool IsValid(string s) {
        // Add open brackets to a Stack
        // When we see a closing bracket, we peek from the Stack and see if it's matching
        // If it's a match, we pop off the stack. If it's not a match, we return false.
        // When done iterating thru the string, if stack is empty we can return true.
        
        var stack = new Stack<char>();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') {
                stack.Push(s[i]);
            } else if (s[i] == '[') {
                stack.Push(s[i]);
            } else if (s[i] == '{') {
                stack.Push(s[i]);
            } else if (s[i] == ')') {
                if (stack.Count > 0 && stack.Peek() == '(') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (s[i] == ']') {
                if (stack.Count > 0 && stack.Peek() == '[') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (s[i] == '}') {
                if (stack.Count > 0 && stack.Peek() == '{') {
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }
        
        return stack.Count == 0 ? true : false;
    }
}