// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите по очереди два числа");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool inSquare = InSquare(number1, number2);
Console.WriteLine(inSquare ? "Да" : "Нет");

bool InSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}