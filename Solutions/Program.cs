#region Unique Characters
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
    char[] vowel = { 'a', 'e', 'i', 'u', 'o','A','E','I','U','O' };
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