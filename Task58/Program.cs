// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Матрицу P можно умножить на матрицу K только в том случае,
// если число столбцов матрицы P равняется числу строк матрицы K.
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

int aRows = Input("Введите колличество строк 1-ой матрицы: ");
int aColumns = Input("Введите количество столбцов 1-ой матрицы: ");
int bRows = Input("Введите колличество строк 2-ой матрицы: ");
int bColumns = Input("Введите количество столбцов 2-ой матрицы: ");
int min = Input("Введите диапазон чисел от min: ");
int max = Input("Введите диапазон чисел до max: ");

string error = "Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы";


if (aColumns == bRows)
{
    int[,] firstMatrix = CreateArr2D(aRows, aColumns, min, max + 1);
    int[,] secondMatrix = CreateArr2D(bRows, bColumns, min, max + 1);
    PrintArr2D(firstMatrix);
    Console.WriteLine();
    PrintArr2D(secondMatrix);
    int[,] resultMatrix = ProductMatrix(firstMatrix, secondMatrix, aColumns, bRows);
    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц: ");
    PrintArr2D(resultMatrix);
}
else
{
    Console.WriteLine(error);
}



int[,] ProductMatrix(int[,] aMatrix, int[,] bMatrix, int aCol, int bRow)
{
    int[,] newArr2D = new int[aMatrix.GetLength(0), bMatrix.GetLength(1)];
    for (int i = 0; i < aMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < bMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < aMatrix.GetLength(1); k++)
            {
                sum += aMatrix[i, k] * bMatrix[k, j];
            }
            newArr2D[i, j] = sum;
        }
    }
    return newArr2D;
}


int[,] CreateArr2D(int aRows, int aColumns, int min, int max)
{
    int[,] arr2D = new int[aRows, aColumns];
    Random rnd = new Random();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}

void PrintArr2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int Input(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
