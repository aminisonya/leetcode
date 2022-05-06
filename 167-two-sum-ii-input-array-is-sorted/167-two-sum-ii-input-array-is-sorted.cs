public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Two pointer technique. Opposite directional pointers.
        // Only one possible solution
        
        var left = 0;
        var right = numbers.Length - 1;
        var result = new int[2];
        
        for (var i = 0; i < numbers.Length; i++)
        {
            var currSum = numbers[left] + numbers[right];
            
            if (currSum > target)
            {
                right--;
            }
            else if (currSum < target)
            {
                left++;
            }
            else if (currSum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                return result;
            }
        }
        
        return result;
    }
}