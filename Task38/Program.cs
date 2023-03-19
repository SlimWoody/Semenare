// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2C

double[] array = CreateArrayRndDouble(5, 1, 99);
PrintArrayDouble(array);
double diffMaxMinElement = DiffMaxMinElement(array);
Console.WriteLine($"-> {diffMaxMinElement}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble () * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double DiffMaxMinElement(double[] arr)
{

    double max = array[0];
    double min = array[0];
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] < min) min = array[i];
        if (arr[i] > max) max = array[i];

    }
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}