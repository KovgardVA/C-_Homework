// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Не использовать строки для расчета.

int Module(int module)
{
    if (module < 0)
    {
        module = -module;
    }
    return module;
}

int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Давайте найдем вторую цифру трехзначного числа!");
int number = Prompt("Введите число: ");

int secondNumber = 0;
number = Module(number); // Числа могут быть не только положительными, но там тоже есть вторая цифра.
if (number > 99 & number < 1000)
{
    secondNumber = (number / 10) % 10; // Отрезаем третью цифру (/ 10) и забираем вторую (% 10).
    Console.WriteLine($"Вторая цифра этого числа: {secondNumber}");
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}