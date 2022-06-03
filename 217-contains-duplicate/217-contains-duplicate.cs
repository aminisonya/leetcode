public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // Use hashset to see if array contains duplicates
        
        var hashset = new HashSet<int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (hashset.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                hashset.Add(nums[i]);
            }
        }
        
        return false;
    }
}