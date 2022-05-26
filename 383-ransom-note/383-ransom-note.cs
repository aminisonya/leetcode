public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        // Does magazine containe all characters of ransomNote?
        // Use a dict and keep count of each character
        
        var dict = new Dictionary<char, int>(); // character : count of char
        for (var i = 0; i < magazine.Length; i++)
        {
            if (!dict.ContainsKey(magazine[i]))
            {
                dict.Add(magazine[i], 0);
            }
            
            dict[magazine[i]]++;
        }
        
        for (var i = 0; i < ransomNote.Length; i++)
        {
            if (!dict.ContainsKey(ransomNote[i]))
            {
                return false;
            }
            else
            {
                if (dict.ContainsKey(ransomNote[i]) && dict[ransomNote[i]] <= 0)
                {
                    return false;
                }
                
                dict[ransomNote[i]]--;
            }
        }
        
        return true;
    }
}