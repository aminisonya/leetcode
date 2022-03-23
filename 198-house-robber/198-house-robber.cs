public class Solution {
    public int Rob(int[] nums) {
        // At most, we want to skip 2 houses
        // If we skip 3 houses, we might as well have included the inbetween house, as only positive numbers are valid
        // So, we can skip either 1 or 2 houses from each house (n + 1 or n + 2)
        // Want the MAX amount from either of those paths.
        // Want to memoize, don't want to repeat calculations
        
        var memo = new Dictionary<int, int>(); // Index as key, max money as value for that index
        return Math.Max(MaxMoney(nums, 0, memo), MaxMoney(nums, 1, memo));
    }
    
    public int MaxMoney(int[] nums, int index, Dictionary<int, int> memo)
    {
        if (index >= nums.Length)
        {
            return 0;
        }
        
        if (memo.ContainsKey(index))
        {
            return memo[index];
        }
        
        var currMax = 0;
        
        if (index == nums.Length - 1)
        {
            // No further paths from here
            memo.Add(index, nums[index]);
            return nums[index];
        }
        else
        {
            // The max profit for this index is the amount from this index plus the max amount that could be gained from either path it could take
            currMax = nums[index] + Math.Max(MaxMoney(nums, index + 2, memo), MaxMoney(nums, index + 3, memo));
            memo.Add(index, currMax);
        }
        
        return currMax;
    }
}