// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintArray2D (matrix);
int[] array = ConvertingMatrixTwoArray (matrix);
Console.WriteLine();
FrequencyDictionary (array);

void FrequencyDictionary (int[]arr)
{
    int count = 1;
    int value = arr[0];
    Array.Sort(arr); // сортирует от мин до макс

    for (int i = 1; i < arr.Length; i++)
    {
        if (value == arr[i]) count++;
        else 
        {
            Console.WriteLine($"{value} ---> {count}");
            value = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{value} ---> {count}");
}

int[] ConvertingMatrixTwoArray (int[,]arr2D)
{
    int[] newArray = new int[arr2D.Length];
    int k = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            newArray[k] = arr2D[i, j];
            k++;
        }
    }
    return newArray;
}

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