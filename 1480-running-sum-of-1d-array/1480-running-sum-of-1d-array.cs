public class Solution {
    public int[] RunningSum(int[] nums) {
        var result = new int[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0)
            {
                result[i] = nums[i] + result[i - 1];
            }
            else
            {
                result[i] = nums[i];
            }
        }
        
        return result;
    }
}