// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.Clear();
Console.Write("Введите длину строки массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца массива: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите диапозон чисел в массиве:  ");
Console.Write("от ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("до ");
int before = Convert.ToInt32(Console.ReadLine());

int[,] NewRndArray(int line, int column, int from, int before)
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
int[,] newRndArray = NewRndArray(line, column, from, before);
Console.WriteLine("Новый двумерный массив: ");
PrintArray(newRndArray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = 0;
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}
SortArray(newRndArray);
Console.WriteLine("Отсортированный массив: ");