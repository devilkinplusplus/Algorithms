#region High and Low string num
using System.Collections.Generic;

string HighAndLow(string numbers)//1 2 3 4 5
{
    string result = string.Empty;
    string[] strings = numbers.Split(' ');
    int[] nums = new int[strings.Length];

    //convert to int
    for (int i = 0; i < strings.Length; i++)
    {
        nums[i] = int.Parse(strings[i]);
    }

    //sort the array
    Array.Sort(nums);

    int temp = nums[0];
    int max = nums[0];
    int min = nums[0];
    //find the max
    for (int i = 0; i < nums.Length; i++)
    {
        if (temp < nums[i])
        {
            max = nums[i];
        }
    }
    //find the min
    for (int i = 0; i < nums.Length; i++)
    {
        if (temp > nums[i])
        {
            min = nums[i];
        }
    }

    result = Convert.ToString(max) + " " + Convert.ToString(min);

    return result;
}

Console.WriteLine(HighAndLow("1 2 3 4 5"));
// other stuff
string HighAndLow2(string numbers)
{
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
}
#endregion


#region Growth of a Population
/*
1000 + 2% + 50 = 1200 how many years?
*/
int NbYear(int p0, double percent, int aug, int p)
{
    int year = 0;
    double temp = 0;

    while (p0 < p)
    {
        temp = p0 + p0 * percent / 100 + aug;
        p0 = (int)temp;
        year++;
    }

    return year;
}
Console.WriteLine(NbYear(1000, 2, 50, 1200));
#endregion


#region Trinagual numbers
/*
 * 1  ; * * 2 ; * * * 3
        *       * *
        *       *
 */
int Triangular(int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(Triangular(3));
#endregion

#region Sum triangular numbers
// 6
// 1,1+2,1+2+3,1+2+3+4,1+2+3+4+5,1+2+3+4+5+6
// 56
int SumTriangularNumbers(int n)
{
    int sum = 0;
    for (int i = n; i > 0; i--)
    {
        for (int j = i; j > 0; j--)
        {
            sum += j;
        }
    }
    return sum;
}
Console.WriteLine(SumTriangularNumbers(6));
#endregion

#region Centered pentagonal numbers

long Pentagonal(long n)
{
    if (n <= 0)
        return -1;
    return (5 * n * n - 5 * n + 2) / 2;
}

Console.WriteLine(Pentagonal(4));
#endregion


#region Even fibonacci sums

long Fibonacci(int max)
{
    if (max < 2)
        return 0;

    long ef1 = 0, ef2 = 2;
    long sum = ef1 + ef2;

    while (ef2 <= max)
    {

        long ef3 = 4 * ef2 + ef1;
        if (ef3 > max)
            break;
        ef1 = ef2;
        ef2 = ef3;
        sum += ef2;
    }

    return (int)sum;
}
Console.WriteLine(Fibonacci(10));
#endregion


#region Find the n highest elements in a list
Console.WriteLine("=====");
List<int> list = new()
{
    10, 9, 8, 7, 6, 5, 4, 3, 2, 1
};
List<int> Largest(int n, List<int> xs)
{
    var list = xs.OrderByDescending
        (x => x).
        Take(n)
        .ToList();
    return list.OrderBy(x => x).ToList();
}
Console.WriteLine(Largest(2, list));
#endregion