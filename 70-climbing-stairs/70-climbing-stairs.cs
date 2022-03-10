public class Solution {
    public int ClimbStairs(int n) {
        // Similar to fibonacci
        // Can use DP and memoization
        var arr = new int[n + 1];
        return Climb(0, n, arr);
    }
    
    public int Climb(int i, int n, int[] arr)
    {
        if (i > n)
        {
            return 0;
        }
        
        if (i == n)
        {
            return 1;
        }
        
        if (arr[i] > 0)
        {
            return arr[i];
        }
        else
        {
            arr[i] = Climb(i + 1, n, arr) + Climb(i + 2, n, arr);
            return arr[i];
        }
    }
}