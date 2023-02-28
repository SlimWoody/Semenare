// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите по очереди два числа");
Console.Write ("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int multipleNumber = MultipleNumber (numberA, numberB);
if (multipleNumber == 0)
{
    Console.WriteLine ($"Число {numberA} кратно числу {numberB}");
}
else
{
    Console.WriteLine ($"Число {numberA} не кратно числу {numberB} остаток {multipleNumber}");
}

int MultipleNumber (int numA, int numB)
{
    return numA % numB;   
}
