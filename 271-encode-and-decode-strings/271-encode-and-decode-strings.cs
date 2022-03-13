public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        // Because 256 ASCII chars are valid, we want the 257th char to use as a delimiter
        var delimiter = Char.ToString((char)257);
        
        var sb = new StringBuilder();
        
        foreach (var str in strs)
        {
            // Build one long string, adding delimiter between strings
            sb.Append(str);
            sb.Append(delimiter);
        }
        
        // Remove last character, which is just an extra delimiter
        sb.Remove(sb.Length - 1, 1);
        
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {
        // Create an array of strings from the passed in string, splitting on delimiter
        var delimiter = Char.ToString((char)257);
        var stringArr = s.Split(delimiter);
        
        return stringArr.ToArray();
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));