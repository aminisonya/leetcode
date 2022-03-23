public class Solution {
    public string ReverseWords(string s) {
        var stringArr = s.Split(' ');
        var sb = new StringBuilder();
        
        for (var i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i] == " ")
            {
                continue;
            }
            
            var reversedStr = string.Empty;
            for (var j = stringArr[i].Length - 1; j >= 0; j--)
            {
                reversedStr = reversedStr + stringArr[i][j];
            }
            
            sb.Append(reversedStr + " ");
        }
        
        return sb.ToString().Trim();
    }
}