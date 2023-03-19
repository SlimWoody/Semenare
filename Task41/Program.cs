// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите какое кол-во цифр Вы хотите ввести: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RequestNumberArray(number);
PrintArray (array);
int postiveNumber = PositiveNumber(array);
Console.WriteLine($"--> {postiveNumber}");

int[] RequestNumberArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
            Console.Write($"Введите число {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


