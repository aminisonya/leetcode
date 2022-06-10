public class Solution {
    public int EvalRPN(string[] tokens) {
        // Reverse Polish Notation
        // Use a Stack
        // When you see an int, add to stack
        // When you see an operator, do that calculation using last two ints from stack then push result back on to stack
        
        var stack = new Stack<string>();
        
        for (var i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
            {
                var second = Int32.Parse(stack.Pop());
                var first = Int32.Parse(stack.Pop());
                var answer = 0;
                
                switch (tokens[i])
                {
                    case "+":
                        answer = first + second;
                        break;
                    case "-":
                        answer = first - second;
                        break;
                    case "*":
                        answer = first * second;
                        break;
                    case "/":
                        answer = first / second;
                        break;
                }
                stack.Push(answer.ToString());
            }
            else
            {
                // It's an int, push on to stack
                stack.Push(tokens[i]);
            }
        }
        
        return Int32.Parse(stack.Pop());
    }
}