public class Solution {
    public void MoveZeroes(int[] nums) {
        // Iterate and keep count of how many zeroes there are
        // Move non-zeroes to front in order
        // Add zeroes to end of array based on count in beginning
        
        var placeInArray = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[placeInArray] = nums[i];
                placeInArray++;
            }
        }
        
        for (var j = placeInArray; j < nums.Length; j++)
        {
            nums[j] = 0;
        }
    }
}