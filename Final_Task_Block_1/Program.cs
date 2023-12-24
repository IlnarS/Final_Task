string[] unsortedArray = new string[4] {"Hello", "2", "world", ":-)"};
string[] sortedArray = new string[unsortedArray.Length];

void ArraySorting(string[] unsortedArray, string[] sortedArray)
{
    int count = 0;
    for (int i = 0; i < unsortedArray.Length; i++)
    {
        if (unsortedArray[i].Length <= 3)
        {
            sortedArray[count] = unsortedArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArraySorting(unsortedArray, sortedArray);
PrintArray(sortedArray);