public class Solution {
    public int ClimbStairs(int n) {
        // either +1 or +2 each step
        // Use memoization to store calculation results
        // DP problem
        
        var memo = new int[n + 1];
        return ClimbHelper(0, n, memo);
    }
    
    public int ClimbHelper(int i, int n, int[] memo)
    {
        if (i > n)
        {
            return 0;
        }
        
        if (i == n)
        {
            return 1;
        }
        
        if (memo[i] > 0)
        {
            return memo[i];
        }
        
        memo[i] = ClimbHelper(i + 1, n, memo) + ClimbHelper(i + 2, n, memo);
        
        return memo[i];
    }
}