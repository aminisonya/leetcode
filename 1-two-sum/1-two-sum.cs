public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // iterate thru the array and build a dictionary. number : index
        // iterate again thru the array, subtract each number from the target, and see if the dict has that value
        // when it does, you've found the two that add up to the target. create the result array and return that
        
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        
        var result = new int[2];
        for (var i = 0; i < nums.Length; i++)
        {
            var numNeeded = target - nums[i];
            if (dict.ContainsKey(numNeeded) && i != dict[numNeeded])
            {
                result[0] = i;
                result[1] = dict[numNeeded];
            }
        }
        
        return result;
    }
}