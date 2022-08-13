// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] TwoDimensionalArray(int line, int column)
{
    int[,] array = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] twoArray)
{
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            if (j < twoArray.GetLength(1) - 1) Console.Write($"{twoArray[i, j]}, ");
            else Console.Write($"{twoArray[i, j]}");
        }
        Console.WriteLine();
    }
}
void ArithmeticMeanNumber(int[,] array)
{
    Console.WriteLine("---------------------------------------");
    Console.Write("Среднее арифметическое число каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumResult = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumResult += array[i, j];
        }
        sumResult /= array.GetLength(0);
        Console.Write($"{Math.Round(sumResult, 1)}; ");
    }
    Console.WriteLine();
}
int[,] twoDimensionalArray = TwoDimensionalArray(m, n);
Console.WriteLine("Двухмерный массив с рандомными числами:");
Console.WriteLine("---------------------------------------");
PrintArray(twoDimensionalArray);
ArithmeticMeanNumber(twoDimensionalArray);
Console.WriteLine();
