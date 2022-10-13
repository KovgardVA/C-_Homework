// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int Prompt(string massage)
{
    Console.WriteLine(massage);
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

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("В этом числе нет третьей цифры!");
        return false;
    }
    return true;
}

Console.WriteLine("Давайте найдем третью цифру введенного числа!");
int number = Prompt("Введите число: ");

int thirdNumber = 0;
number = Module(number); // Трехзначные числа могут быть не только положительными.

if (ValidateNumber(number))
{
    while (number >= 1000)
    {
        number = number / 10; // Сокращаем число до трехзначного, чтобы потом просто оторвать третью цифру.
    }
    thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра заданного цисла: {thirdNumber}");
}
