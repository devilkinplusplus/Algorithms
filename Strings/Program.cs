#region Unique Characters
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

bool HasUniqueChars(string str)
{
    bool isContains = true;
    for (int i = 0; i < str.Length - 1; i++)
    {
        for (int j = i; j < str.Length - 1; j++)
        {
            if (str[i] == str[j + 1])
            {
                isContains = false;
                break;
            }
        }

    }
    return isContains;
}
Console.WriteLine(HasUniqueChars("hola"));
#endregion

#region Remove Vowels
string Disemvowel(string str)
{
    char[] vowel = { 'a', 'e', 'i', 'u', 'o', 'A', 'E', 'I', 'U', 'O' };
    char[] strArray = str.ToCharArray();
    string newString = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if ((strArray[i] != vowel[0]) && (strArray[i] != vowel[1])
            && (strArray[i] != vowel[2]) && (strArray[i] != vowel[3])
            && (strArray[i] != vowel[4])
            && (strArray[i] != vowel[5]) && (strArray[i] != vowel[6])
            && (strArray[i] != vowel[7]) && (strArray[i] != vowel[8])
            && (strArray[i] != vowel[9]))
        {
            newString += strArray[i];
        }
    }

    return newString;
}
Console.WriteLine(Disemvowel("This website is for losers LOL!"));
#endregion

#region Count of vowels
int GetVowelCount(string str)
{
    int vowelCount = 0;
    char[] strArray = str.ToLower().ToCharArray();
    char[] vowels = { 'a', 'e', 'i', 'u', 'o' };

    for (int i = 0; i < str.Length; i++)
    {
        if ((strArray[i] == vowels[0]) || (strArray[i] == vowels[1])
            || (strArray[i] == vowels[2]) || (strArray[i] == vowels[3]) || (strArray[i] == vowels[4]))
        {
            vowelCount++;
        }
    }

    return vowelCount;
}
Console.WriteLine(GetVowelCount("abracadabra"));
#endregion

#region Swap
//Hello World => HEllO WOrld capitalize all vowels
string Swap(string s)
{
    string result = string.Empty;
    char[] strArray = s.ToCharArray();
    char[] vowels = { 'a', 'e', 'i', 'u', 'o', 'A', 'E', 'I', 'O', 'U' };

    for (int i = 0; i < strArray.Length; i++)
    {
        bool hasUpperChar = false;
        for (int j = 0; j < vowels.Length; j++)
        {
            if (strArray[i] == vowels[j])
            {
                hasUpperChar = true;
                result += strArray[i].ToString().ToUpper();
                continue;
            }
        }
        if (!hasUpperChar)
            result += strArray[i];
    }

    return result;
}
Console.WriteLine(Swap("Hello World"));

//other stuff
string Swap2(string s)
{
    return string.Concat(s.Select(x => "aeiou".Contains(x) ? char.ToUpper(x) : x));
}
#endregion

#region Haha counter
//HaHaHa => male ; hahaha => female
int KookaCounter(string laughing)
{
    return Regex.Matches(laughing, "(Ha)+|(ha)+").Count;
}
Console.WriteLine(KookaCounter("HaHaHahahaHaHa"));
#endregion

#region Shorter Reverse Longer
string ShorterReverseLonger(string a, string b)
{
    a ??= "";
    b ??= "";
    return b.Length > a.Length ? a + string.Concat(b.Reverse()) + a : b + string.Concat(a.Reverse()) + b;
}
Console.WriteLine(ShorterReverseLonger("b_notempty", "b_notempty"));
#endregion


#region LongestRepetition

Tuple<char?, int> LongestRepetition(string input)
{
    if (input != string.Empty)
    {
        string longestRun = new string(input.Select((c, index) => input.Substring(index).TakeWhile(e => e == c))
                                       .OrderByDescending(e => e.Count())
                                       .First().ToArray());
        int s = longestRun.Length;
        return new Tuple<char?, int>(longestRun[0], s);
    }

    return new Tuple<char?, int>(null, 0);
}
Console.WriteLine(LongestRepetition("adbsadssadsaaa"));// 'a',4
#endregion

#region string to PascalCase

string PascalCase(string str)
{
    var textInfo = new CultureInfo("en-US").TextInfo;
    var titleCaseStr = textInfo.ToTitleCase(str);

    return titleCaseStr.Replace(" ","");
}
Console.WriteLine(PascalCase("test case"));//HelloWorld
#endregion