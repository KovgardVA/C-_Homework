// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateDay(int day)
{
    if (day < 1 && day > 7)
    {
        Console.WriteLine("Ой! Вы ввели цифру не обозначающую день недели.");
        return false;
    }
    return true;
}

Console.WriteLine("Давайте найдем выходные дни!");
int weekend = Prompt("Введите число, обозночающее день недели (от 1 до 7): ");

if(ValidateDay(weekend))
{
    if (weekend > 0 && weekend < 6)
    {
        Console.WriteLine("Это будний день :(");
    }
    else
    {
        Console.WriteLine("Ура! Это выходной :)");
    }
}