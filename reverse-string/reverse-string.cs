public class Solution {
    public void ReverseString(char[] s) {
        if (s == null)
        {
            return;
        }
        
        ReverseRecursively(0, s.Length - 1, s);
    }
    
    public void ReverseRecursively(int start, int end, char[] s)
    {
        if (start >= end)
        {
            return;
        }
        
        var temp = s[start];
        s[start] = s[end];
        s[end] = temp;
        
        ReverseRecursively(start + 1, end - 1, s);
    }
}