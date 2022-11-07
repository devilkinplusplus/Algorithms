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
//string HighAndLow2(string numbers)
//{
//    var parsed = numbers.Split().Select(int.Parse);
//    return parsed.Max() + " " + parsed.Min();
//}
#endregion