// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int[] SumInRows(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArray[i] += matrix[i,j];
        }
    }
    return sumArray;
}

int FindIndexMaxMin (int[] array, int fl)
{
    int index = 0;
    for(int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] * fl > array[i + 1] * fl)
        {
            index = i;
        }
    }
    return index;
}


int[,] myMatrix = CreateMatrix(3, 4);
PrintMatrix(myMatrix);
int[] rowElementsSum = SumInRows(myMatrix);
int indexOfMinSum = FindIndexMaxMin(rowElementsSum, -1);

Console.WriteLine($"\nНаименьшая сумма элементов находится в строке с номером: {indexOfMinSum + 1} , и она равна {rowElementsSum[indexOfMinSum]}");