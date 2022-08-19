// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

//Console.Clear();
int[,] newArray = NewTwoDimensionalArray(4, 4);
int[,] NewTwoDimensionalArray(int line, int column)
{
    int[,] array = new int[line, column];
    int rangeDigits = array.GetLength(0) * array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] += rangeDigits;
            rangeDigits--;
        }
    }
    return array;
}

Console.WriteLine("Заполняем массив числами от 1 до 16: ");
PrintArray(newArray);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],2}, ");
            else Console.Write($"{array[i, j],2} ]");
        }
        Console.WriteLine();
    }
}




int[,] spiralArray = SpiralArray(newArray);
int[,] SpiralArray(int[,] spiral)
{

    int temp = spiral.GetLength(1) - 1;
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        int firstLine = i;
        firstLine++;
        temp++;

        for (int j = 0; j < spiral.GetLength(1); j++)
        {
            if (spiral[i, j] > 0)
            {
                spiral[0, i] = firstLine;

            }
            spiral[i, j] = temp;
        }
        // for (int n = 0; n < spiral.GetLength(0); n++)
        // {

        // }

    }
    return spiral;
}
Console.WriteLine();
PrintArray(spiralArray);
