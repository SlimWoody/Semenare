// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число 
// A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите два положительных числа");
Console.WriteLine("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA>0 && numberB>0)
{
int extentNumber = ExtentNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} натуральнтуральная степень {numberB} -> {extentNumber} ");
}
else
{
Console.WriteLine("Введены некорректные данные!");
}

int ExtentNumber(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        
        result =result * num1;
        
    }
    return result;
}

