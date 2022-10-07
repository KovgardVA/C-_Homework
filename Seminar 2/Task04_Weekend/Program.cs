int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Давайте найдем выходные дни!");
int weekend = Prompt("Введите число, обозночающее день недели (от 1 до 7): ");

if (weekend > 0 & weekend < 6)
{
    Console.WriteLine("Это будний день :(");
}
else if (weekend > 5 & weekend < 8)
{
    Console.WriteLine("Ура! Это выходной :)");
}
else
{
    Console.WriteLine("Ой! Вы ввели цифру не обозначающую день недели.");
}