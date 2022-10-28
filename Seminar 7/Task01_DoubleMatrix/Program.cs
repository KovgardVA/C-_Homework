// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int lenRow, int lenColumn)
{
    double[,] array = new double[lenRow, lenColumn];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 5) + random.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateArray(3, 4);
PrintArray(myArray);