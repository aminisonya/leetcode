public class Solution {
    public int MaxProfit(int[] prices) {
        // two pointer approach
        // unsorted array
        // keep track of max profit and min priceseen so far
        
        var maxProfit = 0;
        var minPrice = Int32.MaxValue;
        
        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }
        
        return maxProfit;
    }
}