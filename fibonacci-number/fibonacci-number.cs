public class Solution {
    public int Fib(int n) {
        //use memoization to store intermediate results
        var cache = new Dictionary<int, int>();
        
        return GetFib(n, cache);
    }
    
    public int GetFib(int n, Dictionary<int, int> cache)
    {
        if (n < 2)
        {
            return n;
        }
        
        if (cache.ContainsKey(n))
        {
            return cache[n];
        }
        
        var result = GetFib(n - 1, cache) + GetFib(n - 2, cache);
        cache.Add(n, result);
        
        return result;
    }
}