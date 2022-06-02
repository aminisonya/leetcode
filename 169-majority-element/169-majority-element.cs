public class Solution {
    public int MajorityElement(int[] nums) {
        // Boyer-Moore Voting Algorithm
        // Keep count of current majority candidate. If see a num that is not majority candidate, minus one from count.
        // Once count reaches 0, reset majority candidate to next candidate, and repeat
        
        var count = 0;
        var candidate = nums[0]; // starting with first item in array as first candidate
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
            }
            
            if (nums[i] == candidate)
            {
                count++;
            }
            else if (nums[i] != candidate)
            {
                count--;
            }
        }
        
        return candidate;
    }
}