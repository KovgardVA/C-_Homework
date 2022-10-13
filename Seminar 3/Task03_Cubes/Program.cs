// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Ой! Вы ввели не натуральное число.");
        return false;
    }
    return true;
}

int num = Prompt("Введите натуральное число: ");

if(ValidateNumber(num))
{
    Console.WriteLine($"Кубы чисел от 1 до {num}: ");
    for (int i = 1; i <= num; i ++)
    {
        Console.Write(Math.Pow(i, 3) + " | ");
    }
}