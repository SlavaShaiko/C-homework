// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел:");
int[,,] threeDimensionalArray = ThreeDimensionalArray(2, 2, 2);
int[,,] ThreeDimensionalArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int[] arrayTemp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int m = 0; m < arrayTemp.GetLength(0); m++)
    {
        arrayTemp[m] = new Random().Next(10, 100);
        number = arrayTemp[m];
        if (m >= 1)
        {
            for (int n = 0; n < m; n++)
            {
                while (arrayTemp[m] == arrayTemp[n])
                {
                    arrayTemp[m] = new Random().Next(10, 100);
                    n = 0;
                    number = arrayTemp[m];
                }
                number = arrayTemp[m];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = arrayTemp[count];
                count++;
            }
        }
    }
    return array;
}

PrintThreeDimensionalArray(threeDimensionalArray);
void PrintThreeDimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (k == 0) Console.Write("[");
                if (k < array.GetLength(1) - 1) Console.Write($"{array[i, j, k],3}, ");
                else Console.Write($"{array[i, j, k],3}] ");
            }
        }
        Console.WriteLine();
    }
}

 Console.WriteLine();
PrintLineArray(threeDimensionalArray);
void PrintLineArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
              Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
             Console.WriteLine();
        }
         Console.WriteLine();
    }

}


