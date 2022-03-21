public class Solution {
    public void Rotate(int[] nums, int k) {
        // Using reverse
        // When we rotate k times, k elements from back of array come to front
        // And the rest from the front shift backwards
        
        k = k % nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    
    public void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            var temp = nums[end];
            nums[end] = nums[start];
            nums[start] = temp;
            
            start++;
            end--;
        }
    }
}