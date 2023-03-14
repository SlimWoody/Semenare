// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= number; i += result)
    {
        Console.Write("{0} ", i);
        result = i - result;
    }
    return 0;
