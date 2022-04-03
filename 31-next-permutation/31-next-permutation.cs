public class Solution {
    public void NextPermutation(int[] nums) {
        var i = nums.Length - 2; // start from next to last element
        
        while (i >= 0 && nums[i + 1] <= nums[i])
        {
            i--;
        }
        
        if (i >= 0)
        {
            var j = nums.Length - 1;
            while (nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }
        
        Reverse(nums, i + 1);
    }
    
    public void Swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    
    public void Reverse(int[] nums, int start)
    {
        var end = nums.Length - 1;
        while (start < end)
        {
            Swap(nums, start, end);
            start++;
            end--;
        }
    }
}