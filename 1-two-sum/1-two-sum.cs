public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary
        // Two pass thrus
        
        var dict = new Dictionary<int, int>(); // number : index
        var result = new int[2];
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
            
            var currTarget = target - nums[i];
            
            if (dict.ContainsKey(currTarget) && dict[currTarget] != i)
            {
                result[0] = i;
                result[1] = dict[currTarget];
            }
        }
        
        return result;
    }
}