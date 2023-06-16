public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(costs, (a,b) => (a[0] - a[1]) - (b[0] - b[1]));
        
        int cost = 0, n = costs.Length / 2;
        for(int i = 0; i < n; i++)
            cost += costs[i][0];
        
        for(int i = n; i < costs.Length; i++)
            cost += costs[i][1];
        
        return cost;
    }
}