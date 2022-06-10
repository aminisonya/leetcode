public class Solution {
    public long SubArrayRanges(int[] nums) {
        // Sliding window approach. Two pointers
        // Set BOTH pointers to next num at each iteration
        // Keep track of largest and smallest within each window, and update accordingly
        // At each expansion of window, calc range and add to overall sum
        
        // O(n^2) time complexity
        
        long result = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            var min = nums[i];
            var max = nums[i];
            
            for (var j = i; j < nums.Length; j++)
            {
                min = Math.Min(min, nums[j]);
                max = Math.Max(max, nums[j]);
                
                result += max - min;
            }
        }
        
        return result;
    }
}