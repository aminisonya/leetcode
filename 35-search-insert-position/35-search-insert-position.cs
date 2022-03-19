public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // Binary search
        // Search for target, if not found, return right pointer
        var left = 0;
        var right = nums.Length - 1;
        
        while (left <= right)
        {
            var midpoint = left + (right - left) / 2;
            
            if (nums[midpoint] == target)
            {
                return midpoint;
            }
            
            if (nums[midpoint] > target)
            {
                // Wanna search left half
                right = midpoint - 1;
            }
            else if (nums[midpoint] < target)
            {
                // Wanna search the right half
                left = midpoint + 1;
            }
        }
        
        return right + 1;
    }
}