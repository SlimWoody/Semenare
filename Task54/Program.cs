// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintArray2D(matrix);
Console.WriteLine();
SortDescendArr2D(matrix);
PrintArray2D(matrix);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] arr2D = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}

void PrintArray2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}


void SortDescendArr2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            for (int k = 0; k < arr2D.GetLength(1) -1; k++)
            {
                if (arr2D[i, k] < arr2D[i, k + 1])
                {
                    int temp = arr2D[i, k + 1];
                    arr2D[i, k + 1] = arr2D[i, k];
                    arr2D[i, k] = temp;
                }
            }
        }
    }
}