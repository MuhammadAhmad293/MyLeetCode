

var str = Console.ReadLine();

Console.WriteLine(ConvertFromRomanToInt(str));
Console.WriteLine(RomanToInt(str));

int ConvertFromRomanToInt(string s)
{
    var chars = s.ToCharArray();
    var result = 0;
    var currentValue = 0;
    for (var i = 0; i < chars.Length - 1; i++)
    {
        currentValue = RomanNumerals(chars[i]);
        result += (RomanNumerals(chars[i + 1]) > currentValue ? -1 : 1) * currentValue;
    }

    return result + RomanNumerals(chars[chars.Length - 1]);
}
int RomanNumerals(char c)
{
    switch (c)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
    };
    return 0;
}
// my solution
int RomanToInt(string s)
{
    int sum = 0;
    for (int i = 0; i < s.Length; i++)
    {
        char letter = s[i];
        Dictionary<char, int> romanNumberDic = new() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        if (s.Length < 1 || s.Length > 15)
        {
            return 0;
        }
        romanNumberDic.TryGetValue(letter, out int result);
        if (result > 0)
        {
            if (i + 1 < s.Length && romanNumberDic[s[i + 1]] > romanNumberDic[letter])
            {
                sum -= result;
            }
            else
            {
                sum += result;
            }
        }
    }
    return sum;
}