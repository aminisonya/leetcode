public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];
        var dict = new Dictionary<int, int>(); // number : index
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var temp = target - nums[i];
            
            if (dict.ContainsKey(temp) && dict[temp] != i)
            {
                result[0] = dict[temp];
                result[1] = i;
            }
        }
        
        return result;
    }
}