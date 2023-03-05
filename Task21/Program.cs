// Задача 21

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты для точки А");
Console.Write("Координат xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Координат yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Координат zA: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("Координат xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Координат yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Координат zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double leng = DistancePoints(xA, xB, yA, yB, zA, zB);
Console.WriteLine(Math.Round(leng, 2,MidpointRounding.ToZero));

double DistancePoints(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}
