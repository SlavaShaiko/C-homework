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
Console.Write("Укажите диапозон чисел для массива от ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("до ");
int before = Convert.ToInt32(Console.ReadLine());




int[,] NewRndArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
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
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp = array[0, 0];
            if (temp < array[i, j])
            {
                //int temp = array[i, j + 1];
                array[i, j] = array[j, i];
                //array[i, j] = temp;
            }
        }
    }
}
int[,] newRndArray = NewRndArray(line, column);
PrintMatrix(newRndArray);
Console.WriteLine();
SortArray(newRndArray);
PrintMatrix(newRndArray);













// Console.Clear();
// Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     int temp = array[i, j + 1];
//                     array[i, j + 1] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }





