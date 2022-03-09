public class Solution {
    public int MaxArea(int[] height) {
        // area = w * h
        // use two pointers, starting at outer edges, left and right
        // iterate based on smaller value pointer
        
        var left = 0;
        var right = height.Length - 1;
        var max = 0;
        
        while (left < right)
        {
            var currHeight = Math.Min(height[left], height[right]);
            var width = right - left;
            var area = currHeight * width;
            
            max = Math.Max(max, area);
            
            if (height[left] < height[right])
            {
                left++;
            }
            else if (height[left] >= height[right])
            {
                right--;
            }
        }
        
        return max;
    }
}