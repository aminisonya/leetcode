public class Solution {
    public int MaxProduct(int[] nums) {
        int result = nums[0];
        int maxSoFar = nums[0];
        int minSoFar = nums[0];
        
        for (var i = 1; i < nums.Length; i++)
        {
            var curr = nums[i];
            
            var tempMax = Math.Max(curr, Math.Max(curr * maxSoFar, curr * minSoFar));
            minSoFar = Math.Min(curr, Math.Min(curr * maxSoFar, curr * minSoFar));
            
            maxSoFar = tempMax;
            
            result = Math.Max(result, maxSoFar);
        }
        
        return result;
    }
}