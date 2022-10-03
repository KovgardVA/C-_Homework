// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int [] arr = new int[3];
int i = 0, max = 0;

Console.WriteLine("Введите три числа для сравнения:");

while (i < arr.Length)
{
    arr[i] =  Convert.ToInt32(Console.ReadLine());
    i++;
}

for (i = 0; i < arr.Length; i++)
{
    if(arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine($"Максимальное число из трех: {max}");