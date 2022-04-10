public class Solution {
    public int TotalFruit(int[] fruits) {
        // Sliding window approach with left right pointers
        // Adjust left pointer when dict count > 2
        
        var left = 0;
        var right = 0;
        var max = 0;
        var dict = new Dictionary<int, int>();
        
        while (right < fruits.Length)
        {
            if (dict.ContainsKey(fruits[right]))
            {
                dict[fruits[right]]++;
            }
            else
            {
                dict.Add(fruits[right], 1);
            }
            
            while (dict.Count > 2)
            {
                dict[fruits[left]]--;
                
                if (dict[fruits[left]] == 0)
                {
                    dict.Remove(fruits[left]);
                }
                
                left++;
            }
            
            max = Math.Max(max, right - left + 1);
            
            right++;
        }
        
        return max;
    }
}