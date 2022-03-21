public class Solution {
    public int[] SortedSquares(int[] nums) {
        var result = new int[nums.Length];
        var left = 0;
        var right = nums.Length - 1;
        
        // Can fill out result array going backwards, as we iterate inwards with two pointers
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            var rightSquare = nums[right] * nums[right];
            var leftSquare = nums[left] * nums[left];
            
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