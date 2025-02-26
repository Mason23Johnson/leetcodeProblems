public class Solution {
    public bool IsPalindrome(int x) {

        if (x < 0)
        {
            return false;
        }
        else if (x < 10)
        {
            return true;
        }

        string str = x.ToString();

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);

        return str == reversedStr;
    }
}