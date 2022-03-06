public class Solution {
    public int ClimbStairs(int n) {
        var cache = new int[n + 1];
        
        return Climb(0, n, cache);
    }
    
    public int Climb(int i, int n, int[] cache)
    {
        if (i > n)
        {
            return 0;
        }
        
        if (i == n)
        {
            return 1;
        }
        
        if (cache[i] > 0)
        {
            return cache[i];
        }
        
        cache[i] = Climb(i + 1, n, cache) + Climb(i + 2, n, cache);
        return cache[i];
    }
}