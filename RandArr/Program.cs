// Declare an array, and fill it with random values.

// Генерация
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
    Console.WriteLine(String.Empty);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine(String.Empty);
    Console.WriteLine(String.Empty);
}

// Вызов методов
int[] array = RandArr();
PrintArr(array);

// Генерация double
double[] RandArr()
{
    Console.WriteLine("Generating an array of float numbers:");
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    double min = double.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    double max = double.Parse(Console.ReadLine()!);
    
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().NextDouble() * (max - min) + min;
    }
    return arr;
}

// Вывод double
void PrintArr(double[] arr)
{
    Console.WriteLine(String.Empty);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine(String.Empty);
    Console.WriteLine(String.Empty);
}
