public class Solution {
    
    private int[][] costs;
    private Dictionary<(int n, int color), int> memo; // Using a tuple as key
    
    public int MinCost(int[][] costs) {
        if (costs.Length == 0)
        {
            return 0;
        }
        
        this.costs = costs;
        this.memo = new Dictionary<(int, int), int>();
        
        return Math.Min(PaintCost(0,0), Math.Min(PaintCost(0,1), PaintCost(0,2)));
    }
    
    public int PaintCost(int n, int color)
    {
        // If cost has already been calcuated, then it's in our dictionary. Return that.
        if (memo.ContainsKey((n, color)))
        {
            return memo[(n, color)];
        }
        
        var totalCost = costs[n][color];
        
        if (n == costs.Length - 1)
        {
            // do nothing
        }
        else if (color == 0)
        {
            totalCost = totalCost + Math.Min(PaintCost(n + 1, 1), PaintCost(n + 1, 2));
        }
        else if (color == 1)
        {
            totalCost = totalCost + Math.Min(PaintCost(n + 1, 0), PaintCost(n + 1, 2));
        }
        else if (color == 2)
        {
            totalCost = totalCost + Math.Min(PaintCost(n + 1, 0), PaintCost(n + 1, 1));
        }
        
        // Add to dictionary so this cost is not calculated again
        memo.Add((n, color), totalCost);
        
        return totalCost;
    }
}