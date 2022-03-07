public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        var min = nums[0];
        var left = 0;
        var right = nums.Length - 1;
        
        while (right >= left)
        {
            if (nums[right] > nums[left])
            {
                return nums[left];
            }
            
            var mid = (left + right) / 2;
            
            if (nums[mid] >= nums[mid + 1])
            {
                return nums[mid + 1];
            }
            
            if (nums[mid] < nums[mid - 1])
            {
                return nums[mid];
            }
            
            if (nums[mid] > nums[0])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return min;
    }
}