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
    int max = 0,
        secondMax = 0;
        
    if (array[0] > array[1])
    {
        max = array[0];
        secondMax = array[1];
    }
    else
    {
        max = array[1];
        secondMax = array[0];
    }

    for (int index = 2; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            secondMax = max;
            max = array[index];
        }
        else if (array[index] > secondMax)
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