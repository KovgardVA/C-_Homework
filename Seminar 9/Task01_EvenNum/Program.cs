// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

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

void PrintEvenNumbers(int from, int to)
{
    if (to % 2 != 0) to -= 1;
    if (to < from) return;
    PrintEvenNumbers(from, to - 2);
    Console.Write(to + " ");
}

int firstNumber = Prompt("Введите число от: ");
int secondNumber = Prompt("Введите число до: ");
if(Validate(firstNumber,secondNumber)) PrintEvenNumbers(firstNumber, secondNumber);
else Console.WriteLine("Пожалуйста, введите другие числа!");