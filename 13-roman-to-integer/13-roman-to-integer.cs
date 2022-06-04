public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<char, int>(); // symbol : value
        dict.Add('I', 1);
        dict.Add('V', 5);
        dict.Add('X', 10);
        dict.Add('L', 50);
        dict.Add('C', 100);
        dict.Add('D', 500);
        dict.Add('M', 1000);
        
        // Start off with using the last char in the roman numeral as the initial sum
        // Will add and subtract to the sum going backwards thru the roman numeral values
        // Keep track of last roman numeral seen as well to compare
        var sum = dict[s[s.Length - 1]];
        var last = dict[s[s.Length - 1]];
        
        // Loop thru roman numeral backwards
        for (var i = s.Length - 2; i >= 0; i--)
        {
            // If current value is LESS THAN last value, we know we need to subtract that value
            if (dict[s[i]] < last)
            {
                sum -= dict[s[i]];
            }
            else
            {
                sum += dict[s[i]];
            }
            
            // Update last roman to current
            last = dict[s[i]];
        }
        
        return sum;
    }
}