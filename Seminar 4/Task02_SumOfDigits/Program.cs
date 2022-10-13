// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Module(int moduleNumber)
{
    if (moduleNumber < 0)
    {
        moduleNumber = -moduleNumber;
    }
    return moduleNumber;
}

int SumOfDigits (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

int num = Prompt("Введите натуральное число: ");
Console.Write($"Сумма цифр в числе: {SumOfDigits(Module(num))}");