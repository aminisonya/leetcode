public class Solution {
    public int MinTaps(int n, int[] ranges) {
        var min = 0;
        var max = 0;
        var count = 0;
        
        while (max < n)
        {
            // Choose the tap with max range to the right, for each given value to the left
            for (var i = 0; i < ranges.Length; i++)
            {
                if (i - ranges[i] <= min && i + ranges[i] > max)
                {
                    max = i + ranges[i];
                }
            }
            
            // If max did not change, it means we couldn't expand our range to the right
            // Not possible to water whole garden
            if (max == min)
            {
                return -1;
            }
            
            // Now we have reached max, we want to cover more than this max
            min = max;
            count++;
        }
        
        return count;
    }
}