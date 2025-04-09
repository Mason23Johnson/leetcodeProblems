using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var charSet = new HashSet<char>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left++]);
            }

            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}