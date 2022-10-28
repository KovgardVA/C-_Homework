// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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

double FindNumber(double[,] array, int lineNumber, int columnNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == lineNumber && j == columnNumber) return array[i, j];
        }
    }
    return -1;
}

double[,] myArray = CreateArray(3, 4);
PrintArray(myArray);
Console.WriteLine();

int line = Prompt("Введите индекс строки: ");
int column = Prompt("Введите индекс столбца: ");
Console.WriteLine();

double numberToFind = FindNumber(myArray, line, column);
if (numberToFind == -1) Console.WriteLine ("Элемента с таким индексом в матрице нет!");
else Console.WriteLine ($"Под индексом [{line}, {column}] находится элемент {numberToFind:f1}");