using System;
using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        (int value, string numeral)[] romanMap = new (int, string)[]
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        };

        StringBuilder roman = new StringBuilder();

        foreach (var (value, numeral) in romanMap)
        {
            while (num >= value)
            {
                roman.Append(numeral);
                num -= value;
            }
        }

        return roman.ToString();
    }
}
