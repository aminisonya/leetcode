public class Solution {
    public int Calculate(string s) {
        if (s == null || s == "")
        {
            return 0;
        }
        
        var stack = new Stack<int>();
        var result = 0;
        var num = 0;
        char operation = '+';
        
        for (var i = 0; i < s.Length; i++)
        {
            if (Char.IsDigit(s[i]))
            {
                num = 0;
                while (i < s.Length && Char.IsDigit(s[i]))
                {
                    num = 10 * num + s[i] - '0';
                    i++;
                }
                i--;
            }
            
            if (s[i] != ' ' || i == s.Length - 1)
            {
                if (operation == '+')
                {
                    stack.Push(num);
                }
                else if (operation == '-')
                {
                    stack.Push(-num);
                }
                else if (operation == '*')
                {
                    stack.Push(stack.Pop() * num);
                }
                else if (operation == '/')
                {
                    stack.Push(stack.Pop() / num);
                }
                
                operation = s[i];
                num = 0;
            }
        }
        
        while (stack.Count > 0)
        {
            result = result + stack.Pop();
        }
        
        return result;
    } 
}