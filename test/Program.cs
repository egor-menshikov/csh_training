// Задача: Написать программу, которая из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Метод вывода массива
void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
            Console.Write($"{arr[i]}");
        else
            Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

// Метод создания нового массива с длиной, равной количеству элементов из <=3 символов
string[] ThreeCharFilter(string[] arr)
{
    // Считаем элементы длиной <=3 символов
    int count = 0;
    for (int c = 0; c < arr.Length; c++)
    {
        if (arr[c].Length <= 3)
            count++;
    }

    // Создаем новый массив длины count и заполняем его
    string[] result = new string[count];
    int shift = 0;
    for (int i = 0; i < count; i++)
    {
        for (int j = i + shift; j < arr.Length; j++)
        {
            if (arr[j].Length <= 3)
            {
                result[i] = arr[j];
                break;                
            }
            else shift++;
        }
    }
    return result;
}

// Входные массивы
string[] str1 = { "Hi", "Hello", "2", "5", "cat", "world", ":-)", "horse", "white", "sun" };
string[] str2 = {"1234", "1567", "-2", "computer science"};
string[] str3 = {"Russia", "Denmark", "Kazan"};

// Запускаем
Console.WriteLine("================================================================");
Console.WriteLine("input:");
PrintArr(str1);
string[] answer1 = ThreeCharFilter(str1);
Console.WriteLine("output:");
PrintArr(answer1);

Console.WriteLine("================================================================");
Console.WriteLine("input:");
PrintArr(str2);
string[] answer2 = ThreeCharFilter(str2);
Console.WriteLine("output:");
PrintArr(answer2);

Console.WriteLine("================================================================");
Console.WriteLine("input:");
PrintArr(str3);
string[] answer3 = ThreeCharFilter(str3);
Console.WriteLine("output:");
PrintArr(answer3);