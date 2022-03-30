public class Solution {    
    public IList<IList<int>> Permute(int[] nums) {
        // Backtracking for all combinations of ints in nums array
        var result = new List<IList<int>>();
        
        var numsList = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            numsList.Add(nums[i]);
        }
        
        var n = nums.Length;
        Backtrack(n, numsList, result, 0);
        
        return result;
    }
    
    public void Backtrack(int n, List<int> nums, List<IList<int>> result, int first)
    {
        if (first == n)
        {
            result.Add(new List<int>(nums));
        }
        
        for (var i = first; i < n; i++)
        {
            var temp = nums[first];
            nums[first] = nums[i];
            nums[i] = temp;
            
            Backtrack(n, nums, result, first + 1);
            
            var temp2 = nums[first];
            nums[first] = nums[i];
            nums[i] = temp2;
        }
    }
}