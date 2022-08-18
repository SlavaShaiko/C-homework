// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] newRndArray = NewRndArray(6, 6, -50, 50);
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

Console.WriteLine("Прямоугольный двумерный массив: ");
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

int[] sumRowValue = SumRowValue(newRndArray);
int[] SumRowValue(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i, j];
        }
        arr[i] = Sum;
    }
    return arr;
}

Console.Write("Сумма элементов в каждой строке: ");
PrintNewArray(sumRowValue);
void PrintNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

Console.WriteLine();
MinRowElement(sumRowValue);
Console.WriteLine();
void MinRowElement(int[] array)
{
    int imin = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
            imin = i;
        }
    }
    Console.WriteLine($"Номер индекса строки с наименьшей суммой элементов: " +
                                    $"newRndArray[{imin},j], сумма элементов в строке= {min}.");
}