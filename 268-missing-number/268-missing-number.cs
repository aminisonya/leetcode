public class Solution {
    public int MissingNumber(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        foreach (var num in nums)
        {
          dict.Add(num, num);
        }

        for (var i = 0; i <= nums.Length; i++)
        {
          if (!dict.ContainsKey(i))
          {
            return i;
          }
        }
        
        return 0;
    }
}