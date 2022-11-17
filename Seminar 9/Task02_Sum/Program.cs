// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validate(int from, int to)
{
    if (from == to || from > to) return false;
    return true;
}

int Sum(int from, int to)
{
    if (from > to) return 0;
    return from + Sum(from + 1, to);
}

int firstNumber = Prompt("Введите число от: ");
int secondNumber = Prompt("Введите число до: ");
if(Validate(firstNumber,secondNumber))
{
    Console.WriteLine($"Сумма всех натуральных чисел равна {Sum(firstNumber, secondNumber)}");
}
else Console.WriteLine("Пожалуйста, введите другие числа!");