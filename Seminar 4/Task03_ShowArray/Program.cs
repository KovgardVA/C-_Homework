// Напишите программу, которая задаёт массив из 8 случайных элементов
// и выводит их на экран.

int[] FillArray(int length)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(-100,100);
    return collection;
}

void PrintArrya(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++) Console.Write(col[position] + " ");
}

PrintArrya(FillArray(8));