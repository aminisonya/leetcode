public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];
        
        // left and right pointers
        var left = 0;
        var right = numbers.Length - 1;
        
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            
            if (sum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                return result;
            }
            
            if (sum > target)
            {
                right--;
            }
            else if (sum < target)
            {
                left++;
            }
        }
        
        return result;
    }
}