public class LogSystem {

    public Dictionary<int, long> Logs = new Dictionary<int, long>();
    
    public LogSystem() 
    {
    }
    
    public void Put(int id, string timestamp) {
        // Here we will modify the timestamp, bc we will need to later compare it
        var modTime = timestamp.Replace(":", "");        
        Logs.Add(id, long.Parse(modTime));
    }
    
    public IList<int> Retrieve(string start, string end, string granularity) {
        // Need a way to compare timestamps with start and end strings
        // Convert string timestamps to long datatype
        
        var startLong = long.Parse(start.Replace(":", ""));
        var endLong = long.Parse(end.Replace(":", ""));
        long div = 1;
        
        // switch statement to adjust div value for each different granularity
        switch (granularity)
        {
            case "Year":
                div = 10000000000;
                break;
            case "Month":
                div = 100000000;
                break;
            case "Day":
                div = 1000000;
                break;
            case "Hour":
                div = 10000;
                break;
            case "Minute":
                div = 100;
                break;
            case "Second":
                div = 1;
                break;
            default:
                div = 1;
                break;
        }
        
        startLong = startLong / div;
        endLong = endLong / div;
        
        var result = new List<int>();
        
        foreach (var log in Logs)
        {
            if (log.Value / div >= startLong && log.Value / div <= endLong)
            {
                result.Add(log.Key);
            }
        }
        
        return result;
    }
}

/**
 * Your LogSystem object will be instantiated and called as such:
 * LogSystem obj = new LogSystem();
 * obj.Put(id,timestamp);
 * IList<int> param_2 = obj.Retrieve(start,end,granularity);
 */