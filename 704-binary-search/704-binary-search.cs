public class Solution {
    public int Search(int[] nums, int target) {
        // Binary search O(log n)
        // array is already sorted
        
        var left = 0;
        var right = nums.Length - 1;
        
        while (left <= right)
        {
            var mid = right - left / 2;
            
            if (nums[mid] > target)
            {
                // mid - 1 because we're searching to the left
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                // mid + 1 bc we're searching to the right
                left = mid + 1;
            }
            else if (nums[mid] == target)
            {
                return mid;
            }
        }
        
        return -1;
    }
}