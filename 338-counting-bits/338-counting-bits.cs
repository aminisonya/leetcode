public class Solution {
    public int[] CountBits(int n) {
        // can use prev calculated values to get current values
        // any even number will have same number of ones as that number divided by 2
        // an odd number will have same number of ones as that odd number divided by 2, plus 1
        
        var result = new int[n + 1];
        
        for (var i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = result[i/2];
            }
            else
            {
                result[i] = result[i/2] + 1;
            }
        }
        
        return result;
    }
}