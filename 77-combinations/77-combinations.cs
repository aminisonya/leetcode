public class Solution {
    
    private List<IList<int>> output = new List<IList<int>>();
    public int n;
    public int k;
    
    public IList<IList<int>> Combine(int n, int k) {
        // Backtracking to add all possible combinations to list
        this.n = n;
        this.k = k;
        
        Backtrack(1, new List<int>());
        
        return output;
    }
    
    public void Backtrack(int first, List<int> curr)
    {
        // If combination is done
        if (curr.Count == k)
        {
            output.Add(new List<int>(curr));
        }
        
        for (var i = first; i <= n; i++)
        {
            // Add i to the current combination
            curr.Add(i);
            
            // Use next integers to complete the combination
            Backtrack(i + 1, curr);
            
            // Backtrack
            curr.RemoveAt(curr.Count - 1);
        }
    }
}