// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix);
int[] array = SumRowElementArray2D(matrix);
int line = MinElementArray (array);
Console.WriteLine();
Console.WriteLine($"Наименьшая суммa элементов: {line+1} строка");

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

void PrintMatrix(int[,] arr2D)
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

int[] SumRowElementArray2D(int[,] arr2D)
{
    int size = arr2D.GetLength(0);
    int[] array = new int[size];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            array[i] += arr2D[i, j];
        }
    }
    return array;
}

int MinElementArray(int[] array)
{
    int min = array[0], minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}
