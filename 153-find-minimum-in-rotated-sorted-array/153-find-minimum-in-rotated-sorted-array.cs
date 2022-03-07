public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        // Initialize left and right pointers
        var left = 0;
        var right = nums.Length - 1;
        
        // Check if array has been rotated
        // If the last element is greater than the first element, that means the array has NOT been rotated
        if (nums[right] > nums[left])
        {
            return nums[0];
        }
        
        // Binary search to find inflection point
        while (right >= left)
        {
            // Find middle element
            var mid = left + (right - left) / 2;
            
            // If middle element is greater than its next element, then mid+1 element is the smallest
            // This is the point of change
            if (nums[mid] > nums[mid + 1])
            {
                return nums[mid + 1];
            }
            
            // If middle element is lesser than its previous element, then mid element is smallest
            if (nums[mid] < nums[mid - 1])
            {
                return nums[mid];
            }
            
            // If mid element is greater than 0th element
            // the min value is still to the right as we are dealing with elements greater than nums[0]
            if (nums[mid] > nums[0])
            {
                left = mid + 1;
            }
            else
            {
                // If mid element is lesser than 0th element
                // the min value is to the left
                right = mid - 1;
            }
        }
        
        return -1;
    }
}