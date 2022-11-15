// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

bool ValidateMatrixProduct(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne.GetLength(1) == matrixTwo.GetLength(0)) return true;
    return false;
}

int[,] MatrixProduct(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixProduct = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixTwo.GetLength(0); k++)
            {
                matrixProduct[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return matrixProduct;
}

int[,] firstMatrix = CreateMatrix(3, 4);
int[,] secondMatrix = CreateMatrix(4, 2);

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
if(ValidateMatrixProduct(firstMatrix,secondMatrix))
{
    Console.WriteLine("Произведение матриц:");
    PrintMatrix(MatrixProduct(firstMatrix, secondMatrix));
}
else Console.WriteLine("\nПрозведение не может быть выполнено!");