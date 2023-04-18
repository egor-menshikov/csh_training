//Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers WITH -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("The range of random numbers UP TO -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix = new int[row, column];

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillMatrix(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to + 1);
        }
    }
}

int[] FindMinElement(int[,] matr)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    int min_num = matr[0, 0];
    int[] indexes = new int[2];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            if (min_num > matr[i, j])
            {
                min_num = matr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(matr[indexes[0], indexes[1]]);
    return indexes;
}

int[,] WithoutRowColumn(int[,] matr, int[] min_indexes)
{
    int k = 0;
    int p = 0;
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);
    int[,] new_matr = new int[rows - 1, columns - 1];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (min_indexes[0] != i && min_indexes[1] != j)
            {
                new_matr[k, p] = matr[i, j];
                p += 1;
            }
        }
        p = 0;
        if (min_indexes[0] != i) k += 1;
    }
    return new_matr;
}

Console.WriteLine("The random matrix is:");
FillMatrix(matrix, start, stop);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("The minimum element of matrix is:");
int[] minCoord = FindMinElement(matrix);

Console.WriteLine("The new matrix is:");
int[,] answer = WithoutRowColumn(matrix, minCoord);
PrintMatrix(answer);