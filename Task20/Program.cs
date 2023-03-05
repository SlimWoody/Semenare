
Console.WriteLine ("Введите координаты первой точки: ");
Console.Write ("X: ");
int xA= Convert.ToInt32(Console.ReadLine());
Console.Write ("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты второй точки: ");
Console.Write ("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());

double leng = Distance (xA, xB, yA, yB);
Console.WriteLine(Math.Round(leng, 2, MidpointRounding.ToZero));

double Distance (int x1, int x2, int y1, int y2)
{
     return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

// Math.Sqrt(a*a+b*b);
//      Math.Sqrt(5);
//      double d = 5.09987354;
//      double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
//      Console.WriteLine(dRound);