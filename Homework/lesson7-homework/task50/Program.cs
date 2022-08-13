// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите индекс строки: ");
int indexLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());
int[,] RndArray(int line, int column)
{
    Random rnd = new Random();
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
void CheckingArray(int[,] array, int indexLine, int indexColumn)
{
    if (indexLine > array.GetLength(0) || indexColumn > array.GetLength(1))
    {
        Console.Write($"{indexLine}, {indexColumn} -> такого индекса в массиве нет");
    }
    else
    {
        Console.Write($"Значение индексов {indexLine} и {indexColumn} = {array[indexLine, indexColumn]}");
    }
}
int[,] rndArray = RndArray(5, 5);
Console.WriteLine("Двухмерный массив с рандомными числами");
PrintArray(rndArray);
CheckingArray(rndArray, indexLine, indexColumn);
Console.WriteLine();