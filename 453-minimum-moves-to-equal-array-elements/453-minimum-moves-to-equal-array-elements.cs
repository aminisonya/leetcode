public class Solution {
    public int MinMoves(int[] nums) {
        Array.Sort(nums);
        var count = 0;
        
        for (var i = nums.Length - 1; i > 0; i--)
        {
            count += nums[i] - nums[0];
        }
        
        return count;
    }
}