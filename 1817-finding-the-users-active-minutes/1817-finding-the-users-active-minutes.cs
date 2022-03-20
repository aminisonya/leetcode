public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        // Create dictionary to keep track of each unique user
        // And a hashset to keep track of that user's unique active minutes
        var userDict = new Dictionary<int, HashSet<int>>();
        
        // Iterate logs and fill out dictionary/hashset
        foreach (var log in logs)
        {
            if (!userDict.ContainsKey(log[0]))
            {
                userDict.Add(log[0], new HashSet<int>());
            }
            userDict[log[0]].Add(log[1]);
        }
        
        var result = new int[k];
        
        // Iterate user dictionary and fill out result array
        // Result array is 1-indexed, not 0-indexed
        foreach (var user in userDict)
        {
            if (user.Value.Count > 0 && user.Value.Count <= k)
            {
                result[user.Value.Count - 1]++;
            }
        }
        
        return result;
    }
}