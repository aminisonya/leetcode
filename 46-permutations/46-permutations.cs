public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        // Backtracking
        // Try each permutation for each num
        // Current num will be the starting point, backtrack from there
        // Swap current num in iteration with first num
        
        // Convert array to list
        var numsList = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            numsList.Add(nums[i]);
        }
        
        var length = nums.Length;
        var result = new List<IList<int>>();
        
        // Backtracking method
        Backtrack(numsList, result, 0, length);
        
        return result;
    }
    
    private void Backtrack(List<int> nums, List<IList<int>> result, int start, int length)
    {
        // Base case
        // We've found all permutations for this starting point
        if (start == length)
        {
            result.Add(new List<int>(nums));
            return;
        }
        
        // Iterate thru list and find all permutations for starting point
        for (var i = start; i < length; i++)
        {
            // Swap starting num with current iteration num
            var temp = nums[start];
            nums[start] = nums[i];
            nums[i] = temp;
            
            // Backtrack
            Backtrack(nums, result, start + 1, length);
            
            // Swap back to backtrack
            var temp2 = nums[start];
            nums[start] = nums[i];
            nums[i] = temp2;
        }
    }
}