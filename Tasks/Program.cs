// add value to any index of array
string[] players = { "Kim", "Attila" };


void InsertToArray<T>(ref T[] arr, int index, T value)
{
    T[] newArray = new T[arr.Length + 1];
    newArray[index] = value;
    for (int i = 0; i < index; i++)
    {
        newArray[i] = arr[i];
    }
    for (int i = index; i < arr.Length; i++)
    {
        newArray[i + 1] = arr[i];
    }
    arr = newArray;
}

void InsertToLast<T>(ref T[] arr, T value)
{
    InsertToArray(ref arr, arr.Length, value);
}

InsertToArray(ref players, 2, "Gustavo");

foreach (var item in players)
{
    Console.WriteLine(item);
}


//params modifier 
int Sum(params int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
//for using without array
//Console.WriteLine(Sum(1, 2, 3, 4, 521, 51));


int Power(int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= num;
    }
    return result;
}
//Console.WriteLine(Power(5, 2));


int PowerRecursive(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return a * PowerRecursive(a, b - 1);
    }
}

int NumberSum(int value)
{
    if (value<10)
    {
        return value;
    }
    int digit = value % 10;
    int nextValue= value / 10;
    return digit+NumberSum(nextValue);
}

int NumberSumWhile(int value)
{
    int result = 0;
    while (value>0)
    {
        result += value % 10;
        value /= 10;
    }
    return result;
}

//Console.WriteLine(PowerRecursive(2, 4));

Console.WriteLine(NumberSumWhile(512));