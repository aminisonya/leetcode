public class Solution {
    public int MaxProfit(int[] prices) {
        // two pointer approach. non-sorted array.
        // keep track of max profit seen so far
        // min price seen so far and current price used to calc max profit
        
        var maxProfit = 0;
        var minPrice = int.MaxValue;
        
        for (var i = 0; i < prices.Length; i++)
        {
            var curr = prices[i];
            
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            
            maxProfit = Math.Max(maxProfit, curr - minPrice);
        }
                
        return maxProfit;
    }
}