string[] CreateArray(int size)
{
    string[] array = new string[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else    
        Console.Write(array[i] + " ");
    }
}

string[] NewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
        else Array.Resize(ref newArray, array.Length - 1); 
    }
    
    return newArray;
}

Console.Write("Input a number elements: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
Console.Write("This is current array: ");
ShowArray(myArray);
Console.WriteLine();
Console.Write("This is corrected array: ");
string[] newArray = NewArray(myArray);
ShowArray(newArray);