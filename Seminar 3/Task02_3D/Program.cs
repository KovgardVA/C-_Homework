// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(string point)
{
    Console.WriteLine(point);
    int[] Coords = new int[3];
    Coords[X] = Prompt("Координата X: ");
    Coords[Y] = Prompt("Координата Y: ");
    Coords[Z] = Prompt("Координата Z: ");
    return Coords;
}

int[] firstPoint = InputPoint("Введите координаты первой точки:");
int[] secondPoint = InputPoint("Введите координаты второй точки:");

double distance = Math.Sqrt(Math.Pow(secondPoint[X] - firstPoint[X], 2) + Math.Pow(secondPoint[Y] - firstPoint[Y], 2) + Math.Pow(secondPoint[Z] - firstPoint[Z], 2));

Console.WriteLine($"Расстояние между точками: {distance:f2}");