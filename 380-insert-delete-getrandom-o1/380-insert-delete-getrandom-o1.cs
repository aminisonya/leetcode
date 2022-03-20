public class RandomizedSet {

    public Dictionary<int, int> Set;
    public List<int> SetList;
    
    public RandomizedSet() {
        this.Set = new Dictionary<int, int>();
        this.SetList = new List<int>();
    }
    
    public bool Insert(int val) {
        if (!Set.ContainsKey(val))
        {
            SetList.Add(val);
            // Add the value being inserted as key
            // And the index it was inserted into the array/list as value, to be used later
            Set.Add(val, SetList.Count - 1);            
            return true;
        }
        
        return false;
    }
    
    public bool Remove(int val) {
        if (Set.ContainsKey(val))
        {
            // Swap last element with val to be removed
            // Bc we want removal in constant time, and to remove from an array will only be constant time if it's the last element
            
            var lastElement = SetList[SetList.Count - 1];
            var index = Set[val];
            SetList[index] = lastElement;
            Set[SetList[index]] = index;
            
            SetList.RemoveAt(SetList.Count - 1);
            Set.Remove(val); // C# removal from dict is O(1) time
            return true;
        }
        
        return false;
    }
    
    public int GetRandom() {
        // Use Random class in C#
        // Can index an array in constant time, but not a dict. That's why we're using both a dict and array for this solution
        
        var total = SetList.Count;
        var random = new Random();
        var randomInd = random.Next(0, total);
        
        // Index array in O(1) time and return "random" int
        return SetList[randomInd];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */