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
        newArray[i+1] = arr[i];
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
void AddLast<T>(ref T[] arr,T value)
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
void AddFirst<T>(ref T[] arr,T value)
{
    T[] newArray = new T[array.Length + 1];
    newArray[0] = value;
    int counter = 0;
    for (int i = 1 ; i < arr.Length+1; i++)
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
