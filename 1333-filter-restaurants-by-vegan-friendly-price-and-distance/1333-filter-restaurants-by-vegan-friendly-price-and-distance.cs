public class Solution {
    public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance) {
        // loop thru entire restaurant array
        // build array with restaurants that meet criteria
        // sort array based on rating
        // result list is array of restaurant IDs
        
        var filtered = new List<int[]>();
        var result = new List<int>();
        
        foreach (var restaurant in restaurants)
        {
            if (veganFriendly == 1)
            {
                if (restaurant[2] == 1 && restaurant[3] <= maxPrice && restaurant[4] <= maxDistance)
                {
                    filtered.Add(restaurant);
                }
            }
            else
            {
                if (restaurant[3] <= maxPrice && restaurant[4] <= maxDistance)
                {
                    filtered.Add(restaurant);
                }
            }
        }
        
        filtered.Sort((a,b) => a[1] == b[1] ? b[0] - a[0] : b[1] - a[1]);
        
        foreach (var restaurant in filtered)
        {
            result.Add(restaurant[0]);
        }
        
        return result;
    }
}