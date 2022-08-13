// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] TwoDimensionalArray(int line, int column)
{
    double[,] array = new double[line, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100))/10;
            
        }
    }
    return array;
}
void PrintArray(double[,] twoArray)
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
double[,] twoDimensionalArray = TwoDimensionalArray(m, n);
PrintArray(twoDimensionalArray);