// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Ой! Вы ввели не пятизначное число.");
        return false;
    }
    return true;
}

string CheckPalindromes(int palindrome)
{
    if
    (
        (palindrome / 10000 == palindrome % 10) && (palindrome / 1000 % 10 == palindrome % 100 / 10)
    )
    {
        return "Это число палиндром!";
    }
    return "Это число не является палиндромом!";
}

int checkNumber = Prompt("Введите пятизначное число: ");
if (ValidateNumber(checkNumber))
{
    Console.WriteLine(CheckPalindromes(checkNumber));
}