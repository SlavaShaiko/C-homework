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
int[,] newRndArray = NewRndArray(3, 3, 1, 6);
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

int[] maximumRowValue = MaximumRowValue(newRndArray);
int[] MaximumRowValue(int[,] array)
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
PrintNewArray(maximumRowValue);
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
MaximumRowElement(maximumRowValue);
void MaximumRowElement(int[] array)
{
    int imax = 0;
    int max = array[0];
    for (int i = 0; i < array.Length; i++) //ищем максимальный элемент
    {
        if (array[i] > max)
        {
            max = array[i];
            Console.WriteLine(max);
            Console.Write("Summa Maximum = {0,2}", max + "    Row number: ");
        }
        Console.WriteLine();
    }
}




