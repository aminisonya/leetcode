public class Solution {
    public int Search(int[] nums, int target) {
        var length = nums.Length;
        
        if (length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }
        
        // Search entire array for breaking point of sort
        // Return index of smallest number
        var breakingPoint = FindBreakingPoint(nums, target, 0, length - 1);
        
        // Check if breakingpoint is target value
        if (nums[breakingPoint] == target)
        {
            return breakingPoint;
        }
        
        // If array is NOT rotated, search entire array
        if (breakingPoint == 0)
        {
            return BinarySearch(nums, target, 0, length - 1);
        }
        
        if (nums[0] > target)
        {
            // If target is LESS THAN first element, want to search RIGHT side of breaking point
            return BinarySearch(nums, target, breakingPoint, length - 1);
        }
        
        // If target value is GREATER THAN first element, want to search LEFT SIDE of breaking point
        return BinarySearch(nums, target, 0, breakingPoint);
    }
    
    public int BinarySearch(int[] nums, int target, int left, int right)
    {
        // Use binary search to find target
        while (left <= right)
        {
            var mid = (left + right) / 2;
            
            if (nums[mid] == target)
            {
                return mid;
            }
            else
            {
                if (nums[mid] > target)
                {
                    // Search to the left
                    right = mid - 1;
                }
                else
                {
                    // Search to the right
                    left = mid + 1;
                }
            }
        }
        
        // If target wasn't found, return -1
        return -1;
    }
    
    public int FindBreakingPoint(int[] nums, int target, int left, int right)
    {
        // Check to see if array has been rotated at all
        if (nums[left] < nums[right])
        {
            return 0;
        }
        
        // Use binary search to find breaking point
        while (left <= right)
        {
            var pivot = (left + right) / 2;
            
            if (nums[pivot] > nums[pivot + 1])
            {
                return pivot + 1;
            }
            else
            {
                if (nums[pivot] < nums[left])
                {
                    right = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                }
            }
        }
        
        return 0;
    }
}