public class Solution {
    public int[] FindBuildings(int[] heights) {
        // Traverse from end to start
        // Keep track of current tallest building
        // If taller than curr tallest, replace curr tallest, and add to list of buildings with ocean view
        // Use stack to keep track of indexes
        // Pop off stack to result array
        
        var currTallest = heights[heights.Length - 1];
        var stack = new Stack<int>();
        stack.Push(heights.Length - 1);
        
        for (var i = heights.Length - 1; i >= 0; i--)
        {
            if (heights[i] > currTallest)
            {
                currTallest = heights[i];
                stack.Push(i);
            }
        }
        
        var stackCount = stack.Count;
        var result = new int[stackCount];
        
        for (var j = 0; j < stackCount; j++)
        {
            var curr = stack.Pop();
            result[j] = curr;
        }
        
        return result;
    }
}