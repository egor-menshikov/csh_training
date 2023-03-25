// Creating arrays

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
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
    Console.WriteLine();
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
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
    Console.WriteLine();
}


// Генерируем 2d массив
int[,] RandArr2D()
{
    Console.WriteLine();
    Console.WriteLine("Generating a 2d array..");
    Console.Write("Enter array rows number: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Enter array columns number: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);

    int[,] arr = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = rand.Next(min, max + 1);
        }
    }
    return arr;
}

// Вывод 2d массива
void PrintArr2D(int[,] arr)
{    
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($"{arr[row, col]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}