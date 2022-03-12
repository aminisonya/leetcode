public class Solution {
    public bool IsValid(string s) {
        // If open parantheses, push on to stack
        // If close parantheses, pop off stack and check if matches last open parantheses
        
        var stack = new Stack<char>();
        
        foreach (var p in s)
        {
            if (p == '(' || p == '{' || p == '[')
            {
                stack.Push(p);
            }
            else
            {
                if (stack.Count <= 0)
                {
                    return false;
                }
                
                var lastP = stack.Pop();
                
                if (lastP == '(' && p != ')')
                {
                    return false;
                }
                else if (lastP == '{' && p != '}')
                {
                    return false;
                }
                else if (lastP == '[' && p != ']')
                {
                    return false;
                }
            }
        }
        
        if (stack.Count != 0)
        {
            return false;
        }
        
        return true;
    }
}