// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D =  CreateMatrixRndInt(3, 4, 1, 10);
PrintArray2D (array2D);
double[] array = AverageColumns (array2D);
Console.WriteLine();
PrintArray (array);




int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] arr2D = new int[rows, columns];
    Random rnd = new Random ();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i,j] = rnd.Next(min, max+1);
        }
    }
    return arr2D;
}

void PrintArray2D (int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i,j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageColumns (int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        double avar = 0;
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            avar += arr2D[i,j];
        }
        avar = avar/arr2D.GetLength(0);
        arr[j] = avar;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1), 5} ");
        else Console.Write($"{Math.Round(arr[i], 1), 5} ");
    }
    Console.WriteLine("]");
}