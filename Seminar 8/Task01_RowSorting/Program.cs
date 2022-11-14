// Задайте двумерный массив. Напишите программу, которая упорядочивает
// по убыванию элементы каждой строки двумерного массива.

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

void BubbleSortInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int numbers = 0; numbers < matrix.GetLength(1); numbers++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
}

int[,] myMatrix = CreateMatrix(3, 4);
PrintMatrix(myMatrix);

BubbleSortInRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);