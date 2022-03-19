public class Solution {
    public int Search(int[] nums, int target) {
        // Binary search to find target
        
        var left = 0;
        var right = nums.Length - 1;
        
        while (left <= right)
        {
            var midpoint = right - left / 2;
            
            if (nums[midpoint] == target)
            {
                return midpoint;
            }
            
            if (nums[midpoint] > target)
            {
                // Want to search the left half
                right = midpoint - 1;
            }
            else
            {
                // Want to search the right half
                left = midpoint + 1;
            }
        }
        
        return -1;
    }
}