public class Solution {
    public string RemoveDuplicates(string s, int k) {
        // Solve problem using a stack of tuples
        
        var stack = new Stack<(char letter, int count)>();
        
        // Iterate thru the string
        foreach (var ch in s.ToCharArray())
        {
            // If the stack is empty, add the current char to it and continue looping
            if (stack.Count == 0)
            {
                stack.Push((ch, 1));
                continue;
            }
            
            // If the top character from the stack doesn't match the current character, then it's not a duplicate. Add it to the stack and continue looping.
            var peek = stack.Peek();
            if (peek.letter != ch)
            {
                stack.Push((ch, 1));
                continue;
            }
            
            // If we made it here, that means there's a duplicate character. Remove it from the stack.
            stack.Pop();
            
            // Was the top of the st
            if (peek.count < k - 1)
            {
                stack.Push((peek.letter, peek.count + 1));
            }
        }
        
        // Now we can build the result string from the remaining non-duplicate characters
        var stringBuilder = new StringBuilder();
        while (stack.Count > 0)
        {
            var (letter, count) = stack.Pop();
            for (var i = 0; i < count; i++)
            {
                stringBuilder.Append(letter);
            }
        }
        
        return new string(stringBuilder.ToString().Reverse().ToArray());
    }
}