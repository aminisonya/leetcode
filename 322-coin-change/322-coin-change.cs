public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // Using DP (memoization) and recursion (BFS)
        
        if (amount < 1)
        {
            return 0;
        }
        
        var cache = new int[amount];
        
        return MinChange(coins, amount, cache);
    }
    
    public int MinChange(int[] coins, int amount, int[] cache)
    {
        if (amount < 0)
        {
            return -1;
        }
        
        if (amount == 0)
        {
            return 0;
        }
        
        // Check cache to see if we've already done this calculation before
        if (cache[amount - 1] != 0)
        {
            return cache[amount - 1];
        }
        
        // Set up default minimum variable as max value, to be replaced by any number smaller
        var min = Int32.MaxValue;
        
        // Recursion thru coins in a BFS manner
        foreach (var coin in coins)
        {
            var result = MinChange(coins, amount - coin, cache);
            if (result >= 0 && result < min)
            {
                // Plus one bc we are acting as if each coin we subtract from total amount is the last coin used to make change
                min = result + 1;
            }
        }
        
        // Check if min variable has been updated or not before updating cache
        cache[amount - 1] = (min == Int32.MaxValue) ? -1 : min;
        return cache[amount - 1];
    }
}