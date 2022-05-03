public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Two pointer
        // One to keep track of current num
        // Another to find next unique element that is also greater than curr num
        
        var i = 0; // First pointer
        for (var j = 1; j < nums.Length; j++)
        {
            // Second pointer is j
            if (nums[i] != nums[j])
            {
                nums[i + 1] = nums[j];
                i++;
            }
        }
        
        return i + 1; // length of unique elements
    }
}