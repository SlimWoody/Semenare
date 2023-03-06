Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int multiplication = Multiplication(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication}");
}
else
{
    Console.WriteLine("Введите целое положительное число!");
}

int Multiplication(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult = mult * i;
        }
    }
    return mult;
}