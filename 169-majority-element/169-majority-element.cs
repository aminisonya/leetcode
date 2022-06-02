public class Solution {
    public int MajorityElement(int[] nums) {
        var n = nums.Length;
        var dict = new Dictionary<int, int>(); // number : num of occurrences
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }
            
            dict[nums[i]]++;
            
            if (dict[nums[i]] > (n / 2))
            {
                return nums[i];
            }
        }
        
        return -1;
    }
}