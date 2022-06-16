public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if (amount < 1)
        {
            return 0;
        }
        
        return CoinChanges(coins, amount, new int[amount]);
    }
    
    private int CoinChanges(int[] coins, int rem, int[] count)
    {
        if (rem < 0)
        {
            return -1;
        }
        
        if (rem == 0)
        {
            return 0;
        }
        
        if (count[rem - 1] != 0)
        {
            return count[rem - 1];
        }
        
        var min = Int32.MaxValue;
        
        foreach (var coin in coins)
        {
            var res = CoinChanges(coins, rem - coin, count);
            
            if (res >= 0 && res < min)
            {
                min = 1 + res;
            }
        }
        
        count[rem - 1] = (min == Int32.MaxValue) ? -1 : min;
        return count[rem - 1];
    }
}