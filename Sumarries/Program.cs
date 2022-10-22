#region Sum array
int Sum(params int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }
    return result;
}
Console.WriteLine(Sum(213, 44, 12, 55, 75, 87));
#endregion

#region Sum numbers
Console.WriteLine();
int SumNums(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine(SumNums(512));

#endregion
