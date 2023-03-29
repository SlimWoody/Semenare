// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int numberM = Input("Введите неотрицательное число m: ");
int numberN = Input("Введите неотрицательное число n: ");

if (numberM > 0 && numberN > 0)
{
    int akkerman = Akkerman(numberM, numberN);
    Console.WriteLine();
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {akkerman}");
}
else
{
    Console.WriteLine();
    Console.WriteLine (">> Введены некорректные данные <<");
}


int Akkerman(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    if (numN != 0 && numM == 0) return Akkerman(numN - 1, 1);
    if (numN > 0 && numM > 0) return Akkerman(numN - 1, Akkerman(numN, numM - 1));
    return Akkerman(numN, numM);
}

int Input(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}