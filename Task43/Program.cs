// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double coordinateX = CoordinatesFindingX(b1, k1, b2, k2);
double coordinateY = CoordinateFindingY(k2, b2, coordinateX);

if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны! ");
}
else
{
    Console.WriteLine($"Точка пересечения двух прямых Х:{coordinateX}  Y:{coordinateY} ");

}


double CoordinatesFindingX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    if (k1 == k2)
    {
        Console.WriteLine("Прямые паралельны! ");
    }
    return x;
}

double CoordinateFindingY(double k2, double b2, double x)
{
    double y = k2 * x + b2;
    return y;
}