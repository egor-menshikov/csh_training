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





// int[] array = new int[10];
// Console.WriteLine("[{0}]", string.Join(", ", array)); // just showing how it looks after creating.


// // void RandArr(int[] arr)
// // {
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         arr[i] = new Random().Next(0, 100);
// //     }
// //     Console.WriteLine("[{0}]", string.Join(", ", arr));
// // }

// // RandArr(array);


// int[] RandArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     }
//     return arr;
// }

// Console.WriteLine("[{0}]", string.Join(", ", RandArr(array)));

