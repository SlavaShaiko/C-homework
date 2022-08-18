// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
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
    int n = spiral.GetLength(1);
    int m = spiral.GetLength(0);
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = m;

    for (int i = 0; i < n * m; i++)
    {
        Console.Write(spiral[row, col] + " ");
        visits--;
        if (visits == 0)
        {
            visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1);
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return spiral;
}
Console.WriteLine();
PrintArray(spiralArray);






// int[,] tempMin = new int[spiral.GetLength(0), spiral.GetLength(1)];
// int length;//= spiral.GetLength(0) * spiral.GetLength(1);
// for (int i = 0; i < spiral.GetLength(0); i++)
// {
//     length = spiral.GetLength(0) * spiral.GetLength(1);
//     for (int j = 0; j < spiral.GetLength(1); j++)
//     {
//         for (int k = 0; k < length; k++)
//         {


//             if (spiral[i, j] < length)
//             {
//                 length = spiral[i, j];
//                 tempMin[i, j] = length;
//             }
//             else
//             {
//                 tempMin[i, j] = length;
//                 length = spiral[i, j];
//             }
//         }
//         Console.Write(length + " ");
//     }


// }