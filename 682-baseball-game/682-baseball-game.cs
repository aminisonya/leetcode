public class Solution {
    public int CalPoints(string[] ops) {
        // Use a stack, pop off ints for operations then push back on to stack
        // Pop all nums off stack to add to final num
        
        var stack = new Stack<int>();
        
        for (var i = 0; i < ops.Length; i++)
        {
            if (ops[i] == "+")
            {
                // sum of prev two scores
                var prev = stack.Pop();
                var prevTwoSum = prev + stack.Peek();
                stack.Push(prev);
                stack.Push(prevTwoSum);
            }
            else if (ops[i] == "D")
            {
                // double prev score
                var prev = stack.Pop();
                var doublePrev = prev * 2;
                stack.Push(prev);
                stack.Push(doublePrev);
            }
            else if (ops[i] == "C")
            {
                // remove prev score entirely
                stack.Pop();
            }
            else
            {
                stack.Push(Int32.Parse(ops[i]));
            }
        }
        
        var sum = 0;
        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            sum += curr;
        }
        
        return sum;
    }
}