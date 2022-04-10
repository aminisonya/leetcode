public class Solution {
    public int MaxSubArray(int[] nums) {
        // Initialize vars with first element
        var currMax = nums[0];
        var max = nums[0];
        
        // Start from second element, we already used first element
        for (var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];
            
            // If current num is greater than current window max, update current max
            currMax = Math.Max(num, currMax + num);
            max = Math.Max(max, currMax);
        }
        
        return max;
    }
}