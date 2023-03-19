// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = CreateMatrixRndInt (rows: 3, columns: 4, min: 1, max: 10);
PrintArray2D (matrix);
SearchElementArray2D (matrix, row, column);



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

void SearchElementArray2D (int[,]arr2D, int ro, int col)
{
    if (ro > arr2D.GetLength(0) || col > arr2D.GetLength(1) || ro<=0 || col <=0 )
    {
        Console.WriteLine($"{ro}, {col} --> Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"{ro}, {col} --> {arr2D[ro-1, col-1]}");
    }
}