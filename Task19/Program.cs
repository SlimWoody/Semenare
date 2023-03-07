// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool polindrom = Polindrom(number);
    Console.WriteLine(polindrom ? "Да" : "Нет");
}
else
{
    Console.WriteLine($"Число {number} не является пятизначным");
}

bool Polindrom(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) - (num1 * 10);
    int num4 = (num % 100) / 10;
    int num5 = num % 10;
    return num1 == num5 && num2 == num4;
}
