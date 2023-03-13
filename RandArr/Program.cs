// Declare an array, and fill it with random values.

int[] array = new int[10];
Console.WriteLine("[{0}]", string.Join(", ", array)); // just showing how it looks after creating.


// void RandArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     }
//     Console.WriteLine("[{0}]", string.Join(", ", arr));
// }

// RandArr(array);


int[] RandArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

Console.WriteLine("[{0}]", string.Join(", ", RandArr(array)));

