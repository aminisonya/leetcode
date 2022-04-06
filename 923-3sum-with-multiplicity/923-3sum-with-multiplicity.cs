public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        long result = 0;
        
        for (var i = 0; i < arr.Length - 2; i++)
        {
            var newTarget = target - arr[i];
            result += TwoSum(arr, newTarget, i+1);
            result %= (int)Math.Pow(10, 9) + 7;
        }
        
        return (int)result;
    }
    
    public int TwoSum(int[] arr, int target, int index)
    {
        var visited = new Dictionary<int, int>();
        var res = 0;
        
        for (var i = index; i < arr.Length; i++)
        {
            var currTarget = target - arr[i];
            
            if (visited.ContainsKey(currTarget))
            {
                res += visited[currTarget];
            }
            
            if (!visited.ContainsKey(arr[i]))
            {
                visited.Add(arr[i], 0);
            }
            
            visited[arr[i]]++;
        }
        
        return res;
    }
}