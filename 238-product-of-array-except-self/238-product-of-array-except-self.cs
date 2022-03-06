public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        var left = new int[length];
        var right = new int[length];
        var answer = new int[length];
        
        // Set up left side products
        left[0] = 1;
        for (var i = 1; i < length; i++)
        {
            left[i] = nums[i - 1] * left[i - 1];
        }
        
        // Set up right side products, going in reverse
        right[length - 1] = 1;
        for (var i = length - 2; i >= 0; i--)
        {
            right[i] = nums[i + 1] * right[i + 1];
        }
        
        // Fill out answer array based on left and right side values
        for (var i = 0; i < length; i++)
        {
            answer[i] = left[i] * right[i];
        }
        
        return answer;
    }
}