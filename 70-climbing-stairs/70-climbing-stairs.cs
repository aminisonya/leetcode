public class Solution {
    public int ClimbStairs(int n) {
        var memo = new int[n + 1];
        var result = ClimbHelper(0, n, memo);
        return result;
    }
    
    public int ClimbHelper(int i, int n, int[] memo)
    {
        if (i == n)
        {
            return 1;
        }
        
        if (i > n)
        {
            return 0;
        }
        
        if (memo[i] > 0)
        {
            return memo[i];
        }
        
        // Fibonacci
        var result = ClimbHelper(i + 1, n, memo) + ClimbHelper (i + 2, n, memo);
        memo[i] = result;
        return result;
    }
}