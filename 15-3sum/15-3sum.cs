public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        
        // If less than 3 values, return empty result
        if (nums == null || nums.Length < 3)
        {
            return result;
        }
        
        // Sort array
        Array.Sort(nums);
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                // If nums[i] is positive number, bc it's a sorted array, we know we can't get to 0 from remaining values
                // Break out of loop
                break;
            }
            else if (i > 0 && nums[i] == nums[i - 1])
            {
                // If current num is same as prev num, continue. We don't want any duplicates
                // & make sure we are not at very first num
                continue;
            }
            else
            {
                // Use helper method for two pointer TwoSum approach
                TwoSum(nums, i, result);
            }
        }
        
        return result;
    }
    
    public void TwoSum(int[] nums, int i, List<IList<int>> result)
    {
        // Two pointers
        var low = i + 1;
        var high = nums.Length - 1;
        
        while (low < high)
        {
            var sum = nums[i] + nums[low] + nums[high];
            
            if (sum < 0)
            {
                low++;
            }
            else if (sum > 0)
            {
                high--;
            }
            else
            {
                // If sum == 0, add current result to list
                var list = new List<int>{
                    nums[i],
                    nums[low],
                    nums[high]
                };
                result.Add(list);
                
                // Keep searching, there could be more, update both pointers
                low++;
                high--;
                
                // Make sure we are not doing duplcates
                while (low < high && nums[low] == nums[low - 1])
                {
                    low++;
                }
            }
        }
    }
}