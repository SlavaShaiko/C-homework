// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите длину М: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] enteringNumbe = EnteringNumber(number);
// int[] EnteringNumber(int num)
// {
//     int ind = 0;
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Введите array [{i}]:");
//         ind = Convert.ToInt32(Console.ReadLine());
//         arr[i] = ind;
//     }
//     return arr;
// }
// void PrintNumber(int[] arra)
// {
//     for (int i = 0; i < arra.Length; i++)
//     {
//         if (i < arra.Length - 1) Console.Write(arra[i] + ", ");
//         else Console.Write($"{arra[i]} -> ");
//     }
// }
// PrintNumber(enteringNumbe);
// int NumberOfNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return  count ;
// }
// int numberOfNumbers = NumberOfNumbers(enteringNumbe);
// Console.Write($"{numberOfNumbers}");