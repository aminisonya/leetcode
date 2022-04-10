public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // Sliding window problem, with for loop
        // Two pointer approach
        var left = 0;
        var sum = 0;
        var minLength = Int32.MaxValue;
        
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            while (sum >= target)
            {
                minLength = Math.Min(minLength, i + 1 - left);
                sum -= nums[left];
                left++;
            }
        }
        
        return (minLength == Int32.MaxValue) ? 0 : minLength;
    }
}