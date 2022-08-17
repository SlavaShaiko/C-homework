// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(-10, 10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }
// }
// int[,] getMatrix = GetMatrix(3, 3);
// PrintMatrix(getMatrix);
// Console.WriteLine();
// SortArray(getMatrix);
// PrintMatrix(getMatrix);

//------------------------------------------------------------------------------------------------

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 33);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// void NewArray(int[,] array)
// {
//     int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 matrix[i, j] = array[j, i];
//                 if (j == 0) Console.Write("[");
//                 if (j < array.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, |");
//                 else Console.Write($"{matrix[i, j],3}]");
//             }
//             Console.WriteLine();
//         }
//     }
//     else
//     {
//         Console.Write($"Неверный размер массива");
//     }
// }
// int[,] getMatrix = GetMatrix(4, 4);
// PrintMatrix(getMatrix);
// Console.WriteLine();
// NewArray(getMatrix);

//-----------------------------------------------------------------------------------------------

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// // // // // int[] NewOneArray(int[,] array)   //Сортировка от 0 до 9.
// // // // // {
// // // // //     int lengtArray = array.GetLength(0) * array.GetLength(1);
// // // // //     int[] matrix = new int[lengtArray];
// // // // //     for (int i = 0; i < array.GetLength(0); i++)
// // // // //     {
// // // // //         for (int j = 0; j < array.GetLength(1); j++)
// // // // //         {
// // // // //             matrix[array[i, j]]++;
// // // // //         }
// // // // //     }
// // // // //     return matrix;
// // // // // }
// int[] NewOneArray(int[,] array)
// {
//     int[] matrix = new int[array.Length];
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             matrix[result] = array[i, j];
//             result++;
//         }
//     }
//     Array.Sort(matrix);
//     return matrix;
// }
// void PrintNewMatrix(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (i == 0) Console.Write("[");
//         if (i < array.Length - 1) Console.Write($"{array[i]},");
//         else Console.Write($"{array[i]}]");

//     }
// }
// void WriteDigitConsole(int[] newOneArray)
// {
//     int number = newOneArray[0];
//     int count = 0;
//     for (int i = 0; i <= newOneArray.Length; i++)
//     {
//         if (newOneArray[i] == number) count++;
//         else
//         {
//             Console.WriteLine($"{number} -> {count}");
//             number = newOneArray[i];
//             count = 1;
//         }
//         if (i == newOneArray.Length - 1)
//             Console.WriteLine($"{number} -> {count}");
//     }
// }
// int[,] getMatrix = GetMatrix(3, 3);
// PrintMatrix(getMatrix);
// Console.WriteLine();
// int[] newOneArray = NewOneArray(getMatrix);
// PrintNewMatrix(newOneArray);
// Console.WriteLine();
// WriteDigitConsole(newOneArray);

//-----------------------------------------------------------------------------------------------

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(-10, 10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// int[] MinNumberArray(int[,] getMatrix)
// {
//     int indexM = 0;
//     int indexN = 0;
//     int min = getMatrix[0, 0];
//     for (int i = 0; i < getMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < getMatrix.GetLength(1); j++)
//         {
//             if (getMatrix[i, j] < min)
//             {
//                 min = getMatrix[i, j];
//                 indexM = i;
//                 indexN = j;
//             }
//         }
//     }
//     return new int[] { indexM, indexN };
// }
// int[,] RemoveCross(int[,] matrixResult, int[] findMinCross)
// {
//     int[,] matrix = new int[matrixResult.GetLength(0) - 1, matrixResult.GetLength(1) - 1];
//     int m = 0;
//     int n = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (m == findMinCross[0]) m++;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (n == findMinCross[1]) n++;
//             matrix[i, j] = matrixResult[m, n];
//             n++;
//         }
//         n = 0;
//         m++;
//     }
//     return matrix;
// }
// int[,] getMatrix = GetMatrix(4, 4);
// PrintMatrix(getMatrix);
// Console.WriteLine();
// int[] minNumberArray = MinNumberArray(getMatrix);
// int[,] removeCrossw = RemoveCross(getMatrix, minNumberArray);
// PrintMatrix(removeCrossw);
