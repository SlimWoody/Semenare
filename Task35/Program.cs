int [] array = CreateArrayRndInt (123, -150, 150);
PrintArray(array);
int arraySearch = ArraySearch(array);
Console.WriteLine($"Количество двузначных элементов массива равно {arraySearch}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
      if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine ("]");
}


int ArraySearch(int[] arrayValue)
{
    int count = 0;
    for (int i = 0;i < array.Length;i++)
    {
        if (array[i] >=10 && array[i]<=99) count ++;
    }
    return count;
}