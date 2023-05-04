int[,] ProductTable(int num)
{
    int[,] result = new int[num, num];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = i; j < result.GetLength(1); j++)
        {
            result[i, j] = (i + 1) * (j + 1);
            result[j, i] = (i + 1) * (j + 1);
        }
    }
    return result;
}

void PrintArr2D(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($"{arr[row, col], 4} ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

Console.Write("enter n:");
int n = int.Parse(Console.ReadLine()!);

int[,] arr = ProductTable(n);
PrintArr2D(arr);

// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= 5; j++)
//     {
//         if (j >= i || j == 1)
//             Console.Write($"{i * j} \t");
//         else Console.Write(" \t");
//     }
//     Console.WriteLine();
// }