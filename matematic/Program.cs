#region High and Low string numer
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
        temp = p0 + p0 * percent/100 + aug;
        p0 = (int)temp;
        year++;
    }

    return year;
}
Console.WriteLine(NbYear(1000, 2,50, 1200));
#endregion