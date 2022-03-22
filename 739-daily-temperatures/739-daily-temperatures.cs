public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];
        var currDay = 0;
        
        for (var i = 0; i < temperatures.Length; i++)
        {
            var currTemp = temperatures[i];
            
            while (stack.Count > 0 && currTemp > temperatures[stack.Peek()])
            {
                var prevTemp = stack.Pop();
                result[prevTemp] = i - prevTemp;
            }
            
            stack.Push(i);
        }
        
        return result;
    }
}