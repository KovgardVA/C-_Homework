// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

Console.WriteLine("Эта программа удалит вторую цифру из случайного трехзначного числа!");
int randomNumber = new Random().Next(100,1000);
Console.WriteLine("Ваше число: " + randomNumber);

int number = (randomNumber / 100) * 10 + randomNumber % 10;

Console.WriteLine($"Число без второй цифры: {number}");