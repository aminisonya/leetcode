public class TweetCounts {

    // Create a dictionary at class level to store tweets along with a list of timestamps
    private Dictionary<string, List<int>> Tweets;

    public TweetCounts() {        
        this.Tweets = new Dictionary<string, List<int>>();
    }
    
    public void RecordTweet(string tweetName, int time) {
        // If a new tweet comes in, add it to dictionary
        if (!Tweets.ContainsKey(tweetName))
        {
            Tweets.Add(tweetName, new List<int>());
        }
        
        // Add timestamp to tweet in dictionary
        Tweets[tweetName].Add(time);
    }
    
    public IList<int> GetTweetCountsPerFrequency(string freq, string tweetName, int startTime, int endTime) {
        // Calculate the delta based on passed in "freq" string
        var delta = 1;
        
        if (freq == "minute")
        {
            delta = 60;
        }
        else if (freq == "hour")
        {
            delta = 60 * 60;
        }
        else if (freq == "day")
        {
            delta = 60 * 60 * 24;
        }
        
        // Calculate how many time chunks there are between this start and end time, based on frequency
        var timeChunk = 1 + (endTime - startTime) / delta;
        
        // Instantiate array with length based on how many time chunks there are
        var result = new int[timeChunk];
        
        // Iterate thru timestamps for this tweet
        // If tweet happened during time frame between start and end times, add 1 to correct slot in array based on time chunks breakdown
        foreach (var time in Tweets[tweetName])
        {
            if (time >= startTime && time <= endTime)
            {
                var i = (time - startTime) / delta;
                result[i]++;
            }
        }
        
        return result.ToList();
    }
}

/**
 * Your TweetCounts object will be instantiated and called as such:
 * TweetCounts obj = new TweetCounts();
 * obj.RecordTweet(tweetName,time);
 * IList<int> param_2 = obj.GetTweetCountsPerFrequency(freq,tweetName,startTime,endTime);
 */