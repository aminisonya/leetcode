public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Iterate thru array 3 separate times.
        // Going forward and going backwards. Create two arrays of forward and backwards values of products of nums so far
        // Third time, multiple the values from those two arrays for the answer array.
        // O(3n) which is O(n) time. O(2n) space for the two arrays.
        
        var forward = new int[nums.Length];
        var backward = new int[nums.Length];
        var result = new int[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                forward[i] = 1;
                continue;
            }
            forward[i] = forward[i - 1] * nums[i - 1];
        }
        
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
            {
                backward[i] = 1;
                continue;
            }
            backward[i] = nums[i + 1] * backward[i + 1];
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = forward[i] * backward[i];
        }
        
        return result;
    }
}