public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
		var result = new int[2];
		
		for (var i = 0; i < nums.Length; i++)
		{
			if (!dict.ContainsKey(nums[i]))
			{
				dict.Add(nums[i], i);
			}
		}
		
		for (var i = 0; i < nums.Length; i++)
		{
			var num = target - nums[i];
			if (dict.ContainsKey(num) && dict[num] != i)
			{
				result[0] = i;
				result[1] = dict[num];
			}
		}
		
		return result;
    }
}