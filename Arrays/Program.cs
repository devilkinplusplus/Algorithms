int[] array = { 213, 44, 512, 21, 56, 78 };

#region Insert value to any index of array

void InsertToArray<T>(ref T[] arr, T value, int index)
{
    T[] newArray = new T[array.Length + 1];
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
InsertToArray(ref array, 100, 3);

foreach (var number in array)
{
    Console.WriteLine(number);
}
#endregion

#region add value to last index of array
Console.WriteLine();
void AddLast<T>(ref T[] arr, T value)
{
    T[] newArray = new T[array.Length + 1];
    newArray[arr.Length] = value;
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }

    arr = newArray;
}

AddLast(ref array, 99);
foreach (var item in array)
{
    Console.WriteLine(item);
}
#endregion

#region add value to first index of an array
Console.WriteLine();
void AddFirst<T>(ref T[] arr, T value)
{
    T[] newArray = new T[array.Length + 1];
    newArray[0] = value;
    int counter = 0;
    for (int i = 1; i < arr.Length + 1; i++)
    {
        newArray[i] = arr[counter];
        counter++;
    }
    arr = newArray;
}
AddFirst(ref array, 3);
foreach (var item in array)
{
    Console.WriteLine(item);
}

#endregion
int[] array3 = { 213, 44, 512, 21, 56, 78 };

#region Delete value from array
//DeleteFromArray(array3,1);
void DeleteFromArray<T>(ref T[] arr, int index)
{
    T[] newArray = new T[arr.Length - 1];

    for (int i = 0; i < index; i++)
    {
        newArray[i] = arr[i];
    }
    for (int i = index; i < arr.Length - 1; i++)
    {
        newArray[i] = arr[i + 1];

    }
    arr = newArray;
}
Console.WriteLine("delete nth index");
DeleteFromArray(ref array3, 3);
foreach (var item in array3)
{
    Console.WriteLine(item);
}
#endregion



int[] array2 = { 213, 44, 512, 21, 56, 78 };

#region Nth smallest number

int NthSmallest(int[] array, int n)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j + 1] < array[j])
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array[n - 1];
}
Console.WriteLine("Nth smallest " + NthSmallest(array2, 4));
#endregion


#region Ordered Count
List<Tuple<char, int>> OrderedCount(string input)
{
    return input
               .GroupBy(x => x)
               .Select(x => Tuple.Create(x.Key, x.Count()))
               .ToList();
}
Console.WriteLine(OrderedCount("abracadabra"));
#endregion