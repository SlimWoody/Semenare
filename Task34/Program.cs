// 34: Задайте массив заполненный
//  случайными положительными трёхзначными 
//  числами. Напишите программу, 
//  которая покажет количество 
//  чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] array = new int [8];

FillArray(array);
PrintArray (array);
int evenNumbersArr = EvenNumbersArr(array);
Console.WriteLine($"В этом массиве четных чисел - {evenNumbersArr} ");

void FillArray (int[] arr)
{
    Random rand = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(200, 600);
    }
}


int EvenNumbersArr (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count ++;
    }
    return count;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i<arr.Length-1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");


}

