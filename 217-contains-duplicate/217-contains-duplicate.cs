public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
		
		for (var i = 0; i < nums.Length; i++)
		{
			if (dict.ContainsKey(nums[i]))
			{
				return true;
			}
			else
			{
				dict.Add(nums[i], nums[i]);
			}
		}
		
		return false;
    }
}