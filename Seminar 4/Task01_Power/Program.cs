// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B (и в нулевую степень).

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidatePower(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Степень должна быть натуральной!");
        return false;
    }
    return true;
}

int PowerOfNumber (int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i ++)
    {
        result *= number;
    }
    return result;
}

int firstNumber = Prompt("Введите число для возведения в степень: ");
int secondNumber = Prompt("Введите натуральную степень (больше нуля): ");
if (ValidatePower(secondNumber)) Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно {PowerOfNumber(firstNumber, secondNumber)}!");