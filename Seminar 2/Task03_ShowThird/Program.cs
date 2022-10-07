int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Module(int module)
{
    if (module < 0)
    {
        module = -module;
    }
    return module;
}

Console.WriteLine("Давайте найдем третью цифру введенного числа!");
int number = Prompt("Введите число: ");

int thirdNumber = 0;
number = Module(number);

if (number < 100)
{
    Console.WriteLine("В этом числе нет третьей цифры!");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра заданного цисла: {thirdNumber}");
}
