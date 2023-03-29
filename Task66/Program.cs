// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = Input("Введите значение M: ");
int numberN = Input("Введите значение N: ");

if(numberM > 0 && numberN > 0) 
{
int sum = SumNumbersMtoN(numberM, numberN);
Console.WriteLine();
Console.WriteLine ($"Сумма всех чисел от {numberM} до {numberN} = {sum}");
}
else
{
    Console.WriteLine();
    Console.WriteLine ($"!Введите натуральные числа!");
}


int SumNumbersMtoN (int numM, int numN)
{
    if (numM < numN)
    {
        return numM + SumNumbersMtoN (numM + 1, numN);
    }

    else if (numM > numN)
    {
        return numM + SumNumbersMtoN (numM - 1, numN);
    }

    else
    {
         return numM;
    }
}


int Input (string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

