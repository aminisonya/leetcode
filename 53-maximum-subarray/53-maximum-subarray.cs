public class Solution {
    public int MaxSubArray(int[] nums) {
        var currSub = nums[0];
		var maxSub = nums[0];
		
		for (var i = 1; i < nums.Length; i++)
		{
			currSub = currSub + nums[i];
			
			if (currSub < nums[i])
			{
				currSub = nums[i];
			}
			
			maxSub = Math.Max(maxSub, currSub);
		}
		
		return maxSub;
    }
}