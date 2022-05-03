public class Solution {
    public int[] SortedSquares(int[] nums) {
        // Two pointers
        // Iterate backwards thru array
        // Two pointers, one on each end of array
        // This will account for negative values which will be positive once squared, and will need to be placed correctly sorted
        var result = new int[nums.Length];
        var left = 0;
        var right = nums.Length - 1;
        
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            var leftSquare = nums[left] * nums[left];
            var rightSquare = nums[right] * nums[right];
            
            if (rightSquare >= leftSquare)
            {
                result[i] = rightSquare;
                right--;
            }
            else
            {
                result[i] = leftSquare;
                left++;
            }
        }
        
        return result;
    }
}