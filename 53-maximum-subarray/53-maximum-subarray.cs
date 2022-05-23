public class Solution {
    public int MaxSubArray(int[] nums) {
        // sliding window approach
        // keep track of curr max and max seen so far
        
        var max = nums[0];
        var currMax = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            currMax = Math.Max(nums[i], currMax + nums[i]);
            
            if (currMax > max)
            {
                max = currMax;
            }
        }
        
        return max;
    }
}