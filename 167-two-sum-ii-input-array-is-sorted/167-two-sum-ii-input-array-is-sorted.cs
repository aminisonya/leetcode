public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Twist on TwoSum
        // Two pointers. Opposite directional.
        // Only one possible solution
        
        var answer = new int[2];
        var left = 0;
        var right = numbers.Length - 1;
        
        while (left < right)
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
                answer[0] = left + 1;
                answer[1] = right + 1;
                return answer;
            }
        }
        
        return answer;
    }
}