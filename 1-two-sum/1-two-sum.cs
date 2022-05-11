public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // dictionary for values
        // two pass thrus of nums array
        
        var result = new int[2];
        
        var dict = new Dictionary<int, int>(); // number : index
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
            
            var currTarget = target - nums[i];
            if (dict.ContainsKey(currTarget) && i != dict[currTarget])
            {
                result[0] = i;
                result[1] = dict[currTarget];
                return result;
            }
        }
        
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     var currTarget = target - nums[i];
        //     if (dict.ContainsKey(currTarget) && i != dict[currTarget])
        //     {
        //         result[0] = i;
        //         result[1] = dict[currTarget];
        //         return result;
        //     }
        // }
        
        return result;
    }
}