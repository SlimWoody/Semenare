// Задача 47. Задайте двумерный массив размером 
// m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2dArray(int rows, int column, int min, int max)
{
    double[,] arr2D = new double[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            double num = rnd.NextDouble()* (max*min)+max;
            arr2D[i, j] = Math.Round(num, 1);
        }
    }
    return arr2D;
}

void Print2dArray (double[,]arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write ("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i,j], 6} ");
        }
        Console.WriteLine("|");
    }
}

double[,] Array2D = Create2dArray (3, 4, -2, 10);
Print2dArray (Array2D);