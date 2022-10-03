// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Блок ввода:

Console.WriteLine("Давайте сравним два числа!");
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чисто: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Сравниваем числа:

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}.");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}.");
}
else
{
    Console.WriteLine("Числа равны! Что тут сравнивать?");
}