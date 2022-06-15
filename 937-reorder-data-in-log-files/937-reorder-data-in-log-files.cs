public class Solution {
    List<string> _letterLogs = new List<string>();
    List<string> _digiLogs = new List<string>();
    
    public string[] ReorderLogFiles(string[] logs) {
        for (var i = 0; i < logs.Length; i++)
        {
            var parts = logs[i].Split(' ');
            if (char.IsDigit(parts[1][0]))
            {
                _digiLogs.Add(logs[i]);
            }
            else
            {
                _letterLogs.Add(logs[i]);
            }
        }
        
        _letterLogs.Sort(new LogComparer());
        _letterLogs.AddRange(_digiLogs);
        
        return _letterLogs.ToArray();
    }
    
    private class LogComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var xParts = x.Split(' ');
            var yParts = y.Split(' ');
            
            var xSort = x.Substring(xParts[0].Length + 1);
            var ySort = y.Substring(yParts[0].Length + 1);
            
            if (xSort.Equals(ySort))
            {
                return xParts[0].CompareTo(yParts[0]);
            }
            else
            {
                return xSort.CompareTo(ySort);
            }
        }
    }
}