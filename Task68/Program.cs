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


int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return Akkerman(numM - 1, 1);
    else return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Input(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}