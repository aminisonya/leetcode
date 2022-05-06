public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var answer = new int[2];
        
        // left and right pointers
        var left = 0;
        var right = numbers.Length - 1;
        
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            
            if (sum == target)
            {
                answer[0] = left + 1;
                answer[1] = right + 1;
                return answer;
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
        
        return answer;
    }
}