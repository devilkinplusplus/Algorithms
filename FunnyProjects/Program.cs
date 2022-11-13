#region Cats and rafs
//1 5 => 2
//2 5 => 1
//3 7 => 2
//unfinished
using System.Runtime.CompilerServices;

int Cats(int start, int finish)
{
    double result1 = (finish - start) / 2;
    double result = Math.Floor(result1);
    if (start >= result)
        return start - 1;
    else
        return start + 1;
}
Console.WriteLine(Cats(11, 23));
#endregion

#region Fizz Buzz

string[] GetFizzBuzzArray(int n)
{
    string[] newArray = new string[n];
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            newArray[i - 1] = "FizzBuzz";
        else if (i % 5 == 0)
            newArray[i - 1] = "Buzz";
        else if (i % 3 == 0)
            newArray[i - 1] = "Fizz";
        else
            newArray[i - 1] = (i).ToString();

    }
    return newArray;
}
Console.WriteLine(GetFizzBuzzArray(3));
#endregion


#region
/*
pyramid(0) => [ ]
pyramid(1) => [ [1] ]
pyramid(2) => [ [1], [1, 1] ]
pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
 */
int[][] Pyramid(int n)
{
    int[][] newPyramid = new int[n][];
    for (int i = 0; i < n; i++)
    {
        newPyramid[i] = Enumerable.Repeat(1, i + 1).ToArray();
    }
    return newPyramid;
}
Console.WriteLine(Pyramid(3));
#endregion

#region Spoonerize
//"not picking" --> "pot nicking"
string Spoonerize(string str)
{
    int spaceBetween = str.LastIndexOf(' ');
    char[] chars = str.ToCharArray();
    string result = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (i == spaceBetween)
        {
            char temp = chars[0];
            chars[0] = chars[i + 1];
            chars[i + 1] = temp;
            result = new string(chars);
            break;
        }
    }

    return result;
}
Console.WriteLine(Spoonerize("pack of lies"));

#endregion