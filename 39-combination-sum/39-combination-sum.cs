public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var results = new List<IList<int>>();
        var comb = new List<int>();
        
        Backtrack(target, comb, 0, candidates, results);
        return results;
    }
    
    private void Backtrack(int remain, List<int> comb, int start, int[] candidates, List<IList<int>> results)
    {
        // Base cases first
        if (remain == 0)
        {
            // we've found a match, add to results list
            results.Add(new List<int>(comb));
            return;
        }
        else if (remain < 0)
        {
            // we've gone past the target amount, return
            return;
        }
        
        for (var i = start; i < candidates.Length; i++)
        {
            comb.Add(candidates[i]);
            Backtrack(remain - candidates[i], comb, i, candidates, results);
            comb.RemoveAt(comb.Count - 1);
        }
    }
}