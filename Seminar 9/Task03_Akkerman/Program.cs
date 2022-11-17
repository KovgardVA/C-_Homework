// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validate(int M, int N)
{
    if (M < 0 || N < 0) return false;
    return true;
}

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}

int firstNumber = Prompt("Введите первое неотрицательное число: ");
int secondNumber = Prompt("Введите второе неотрицательное число: ");
if (Validate(firstNumber, secondNumber))
{
    Console.WriteLine($"Результат вычислений: {Akkerman(firstNumber, secondNumber)}");
}
else Console.WriteLine("Пожалуйста, введите другие числа!");