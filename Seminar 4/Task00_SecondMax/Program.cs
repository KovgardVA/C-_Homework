// Напишите программу, которая из массива случайных чисел.
// Ищет второй максимум (число меньше максимального элемента,
// но больше всех остальных). Постарайтесь сделать одним циклом

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(-100, 100);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write(col[position] + " ");
}

int FindSecondMax(int[] array)
{
    int max = array[0],
        secondMax = array[0];

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            secondMax = max;
            max = array[index];
        }
        if (secondMax == max)
        {
            if (i < array.Length - 1)
            {
                secondMax = array[i + 1];
            }
        }
        if (array[index] > secondMax & array[i] != max)
        {
            secondMax = array[index];
        }
    }
    return secondMax;
}

int[] randomArray = new int[8]; 
FillArray(randomArray);
Console.WriteLine("Наш массив:");
PrintArray(randomArray);

Console.WriteLine($"\nВторое максимальное значение в массиве: {FindSecondMax(randomArray)}!");