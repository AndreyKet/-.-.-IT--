string [] array1 = {"hello", "2","world", ":-)"};
string [] array2 = new string [array1.Length];

SortArray(array1, array2);
PrintArray(array2);

void SortArray(string [] array1, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}


// int count = 0;
// for ( int i = 0 ; i < array1.Length; i++)
// {
//     if (array1[i].Length <= 3)
//     {
//         array2[i] = array1[i];
//         count++;
//     }
//     Console.Write(array2[i] + " ");
// }
// Console.WriteLine();