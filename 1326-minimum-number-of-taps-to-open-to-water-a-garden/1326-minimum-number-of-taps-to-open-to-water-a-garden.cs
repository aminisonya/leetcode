public class Solution {
    public int MinTaps(int n, int[] ranges) {
        // Bit of a brute force solution
        var min = 0;
        var max = 0;
        var count = 0;
        
        // Basically, how many times do we have to update max before we've watered whole garden?
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
            // Not possible to water whole garden, return -1, do not continue searching
            if (max == min)
            {
                return -1;
            }
            
            // Now we have reached max, we want to cover more than this max
            // Set min to max
            min = max;
            count++;
        }
        
        return count;
    }
}