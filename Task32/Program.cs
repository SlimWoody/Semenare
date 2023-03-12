void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }
}

void PrintArray (int [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
      if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine ("]");
}

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = new int [5];
FillArray(array);
PrintArray(array);
InverseArray(array);
PrintArray(array);