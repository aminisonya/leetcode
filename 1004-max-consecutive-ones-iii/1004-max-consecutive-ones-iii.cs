public class Solution {
    public int LongestOnes(int[] nums, int k) {
        // Iterate thru whole array
        // Sliding window
        // As window expands, keep track of number of 1's and number of 0's.
        // If number of 0's < k, can continue expanding window. If 0's > k, update left side of window, and continue.
        // Return out longest window possible with k constraint.
        
        var currOnes = 0;
        var zeroes = 0;
        var left = 0;
        var max = 0;
        
        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 1)
            {
                currOnes++;
            }
            else if (nums[right] == 0)
            {
                zeroes++;
            }            
            
            if (zeroes > k)
            {
                if (nums[left] == 1)
                {
                    currOnes--;
                }
                else if (nums[left] == 0)
                {
                    zeroes--;
                }
                
                left++;
            }
            
            max = Math.Max(max, (right - left + 1));
        }
        
        return max;
    }
}