public class TweetCounts {

    private Dictionary<string, List<int>> Tweets;

    public TweetCounts() {        
        this.Tweets = new Dictionary<string, List<int>>();
    }
    
    public void RecordTweet(string tweetName, int time) {
        if (!Tweets.ContainsKey(tweetName))
        {
            Tweets.Add(tweetName, new List<int>());
        }
        
        Tweets[tweetName].Add(time);
    }
    
    public IList<int> GetTweetCountsPerFrequency(string freq, string tweetName, int startTime, int endTime) {
        //int delta = deltas[freq];
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
        
        var ans = new List<int>(new int[1 + (endTime - startTime) / delta]);
        
        foreach (int time in Tweets[tweetName])
            if (time >= startTime && time <= endTime)
                ans[(time - startTime) / delta]++;
        
        return ans;
    }
}

/**
 * Your TweetCounts object will be instantiated and called as such:
 * TweetCounts obj = new TweetCounts();
 * obj.RecordTweet(tweetName,time);
 * IList<int> param_2 = obj.GetTweetCountsPerFrequency(freq,tweetName,startTime,endTime);
 */