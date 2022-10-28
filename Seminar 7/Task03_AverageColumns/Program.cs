int[,] CreateMatrix(int lenRow, int lenColumn)
{
    int[,] matrix = new int[lenRow, lenColumn];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-5, 5);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] AverageColumns(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] += matrix[i, j];
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int[,] myArray = CreateMatrix(3, 4);
PrintMatrix(myArray);

Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(AverageColumns(myArray));