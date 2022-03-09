public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        
        if (nums == null || nums.Length < 3)
        {
            return result;
        }
        
        Array.Sort(nums);
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }
            else if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            else
            {
                TwoSum(nums, i, result);
            }
        }
        
        return result;
    }
    
    public void TwoSum(int[] nums, int i, List<IList<int>> result)
    {
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
                var temp = new List<int>{
                    nums[i],
                    nums[low],
                    nums[high]
                };
                result.Add(temp);
                high--;
                low++;
                while (low < high && nums[low] == nums[low - 1])
                {
                    low++;
                }
            }
        }
    }
}