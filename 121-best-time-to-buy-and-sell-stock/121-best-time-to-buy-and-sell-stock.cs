public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2)
		{
			return 0;
		}
		
		var max = 0;
		var min = Int32.MaxValue;
		
		for (var i = 0; i < prices.Length; i++)
		{
			if (prices[i] < min)
			{
				min = prices[i];
			}
			
			if (prices[i] - min > max)
			{
				max = prices[i] - min;
			}
		}
		
		return max;
    }
}