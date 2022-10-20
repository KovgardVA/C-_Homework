// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод создания и заполнения массива с консоли с заданным количеством элементов.
int[] FillNewArray (int M)
{
    Console.WriteLine($"Введите {M} чисел:");
    int[] array = new int[M];
    for (int i = 0; i < M; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

// Метод подсчета положительных чисел счетчиком.
int CountOfPositive (int[] collection)
{
    int count = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index] > 0) count++;
    }
    return count;
}

int[] myArray = FillNewArray(5);
Console.WriteLine($"Количество положительных чисел: {CountOfPositive(myArray)}");