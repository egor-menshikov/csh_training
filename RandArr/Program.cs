// Declare an array, and fill it with random values.

// Генерация с аргументами внутри
int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);
    
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

// Вывод
void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
    // Console.WriteLine("[{0}]", string.Join(", ", arr));
}

// Вызов методов
int[] array = RandArr();
PrintArr(array);

// Генерация с аргументами снаружи
Console.Write("Enter array length: ");
int len = int.Parse(Console.ReadLine()!);
Console.Write("Enter minimal range value: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum range value: ");
int max = int.Parse(Console.ReadLine()!);

int[] RandArr(int len, int min, int max)
{         
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
