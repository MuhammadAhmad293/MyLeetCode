using System.Collections.Generic;

Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
string LongestCommonPrefix(string[] strs)
{
    Dictionary<int, char> dict = new();
    Dictionary<int, char> dub = new();

    for (int i = 0; i < strs.Length; i++)
    {
        char[] letter = strs[i].ToCharArray();
        for (int j = 0; j < letter.Length; j++)
        {
            if (!dict.ContainsKey(letter[j]))
                dict.Add((int)letter[j], (char)letter[j]);
            else
                dub.Add((int)letter[j], (char)letter[j]);
        }
    }
    return strs[0];
}