// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();
int[,] firstMatrix = FirstMatrix(4, 4, 1, 10);
int[,] FirstMatrix(int line, int column, int from, int before)
{
    int[,] array = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(from, before);
        }
    }
    return array;
}

int[,] secondMatrix = SecondMatrix(4, 4, 1, 10);
int[,] SecondMatrix(int line, int column, int from, int before)
{
    int[,] array = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(from, before);
        }
    }
    return array;
}

Console.WriteLine($" Задаём две матрицы с рандомными числами: ");
PrintArray(firstMatrix);
Console.WriteLine(" и");
PrintArray(secondMatrix);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3} ");
            else Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[,] productTwoMatrices = ProductTwoMatrices(firstMatrix, secondMatrix);
int[,] ProductTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newArray = new int[firstMatrix.GetLength(1), secondMatrix.GetLength(0)];
    if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
    {
        int j;
        for (int i = 0; i < firstMatrix.GetLength(1); i++)
        {
            for (j = 0; j < secondMatrix.GetLength(0); j++)
            {
                newArray[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
            }
            j = 0;
        }
    }
    else
        Console.WriteLine("Не совпадает длина строки с длиной столбца");
    return newArray;
}
Console.WriteLine(" Произведение двух матриц: ");
PrintArray(productTwoMatrices);