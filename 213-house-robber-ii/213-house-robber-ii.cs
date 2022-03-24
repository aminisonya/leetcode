public class Solution {
    
    private Dictionary<int, int> memo = new Dictionary<int, int>(); // Index as key and max profit as value
    
    public int Rob(int[] nums) {
        // "Circular" array of houses. Adjacent houses cannot be robbed
        // Same problem as House Robber I, except must be mindful of where you can stop robbing
        
        if (nums.Length == 0)
        {
            return 0;
        }
        else if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        
        return Math.Max(MaxProfit(nums, 0, nums.Length - 2), MaxProfit(nums, 1, nums.Length - 1));
    }
    
    public int MaxProfit(int[] nums, int index, int last)
    {
        var prevPrev = nums[index];
        var prev = Math.Max(nums[index], nums[index + 1]);
        
        for (var i = index + 2; i <= last; i++)
        {
            var curr = Math.Max(prevPrev + nums[i], prev);
            prevPrev = prev;
            prev = curr;
        }
        
        return Math.Max(prevPrev, prev);
    }
}