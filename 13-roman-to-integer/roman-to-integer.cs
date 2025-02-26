class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanNums = new Dictionary<char, int>
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        int total = 0;
        int previousValue = 0;

        foreach (char numeral in s)
        {
            int currentValue = romanNums[numeral];

            if (currentValue > previousValue)
            {
                total += currentValue - 2 * previousValue;
            }
            else
            {
                total += currentValue;
            }

            previousValue = currentValue;
        }

        return total;
    }

}
