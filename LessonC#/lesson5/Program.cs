// Андрей Булгаков: Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
/*
Console.Clear();
int[] GreateArrayRndDig(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] SumPosNegDig(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sumNeg += arr[i];
        else
            sumPos += arr[i];
    }
    return new int[] { sumNeg, sumPos };
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] greateArrayRndDig = GreateArrayRndDig(12, -9, 9);
int[] sumPosNegDig = SumPosNegDig(greateArrayRndDig);
PrintArray(greateArrayRndDig);
Console.WriteLine();
Console.WriteLine($"сумма отрицательных чисел равна {sumPosNegDig[0]}");
Console.WriteLine($"сумма положительных чисел равна {sumPosNegDig[1],3}");
*/
//---------------------------------------------------------------------------------------------------------
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
/*Console.Clear();
int[] GreateArrayRndDig(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void ArrayDig(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] greateArrayRndDig = GreateArrayRndDig(4, -9, 9);
PrintArray(greateArrayRndDig);
ArrayDig(greateArrayRndDig);
Console.Write(" -> ");
PrintArray(greateArrayRndDig);
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------
/*Андрей Булгаков: Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] ArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void DefiningGivenNumber(int[] array, int dig)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == dig)
        {
            Console.Write("-> да");
            return;
        }
    }
    Console.WriteLine($"-> нет");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
Console.Write($"{number}; массив ");
int[] arrayRnd = ArrayRnd(12, 0, 33);
PrintArray(arrayRnd);
DefiningGivenNumber(arrayRnd, number);
Console.WriteLine();
*/
//------------------------------------------------------------------------------------------------------------------------------------
/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
Console.Clear();
int[] ArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] SumPosNegDig(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 100)
            count += 1;
        else
            count += 0;
    }
    return new int[] { count };
}

int[] arrayRnd = ArrayRnd(123, 0, 124);
PrintArray(arrayRnd);
int[] sumPosNegDig = SumPosNegDig(arrayRnd);
Console.WriteLine($" -> {sumPosNegDig[0]}");
*/
//------------------------------------------------------------------------------------------------------------------------------------------------
/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
Console.Clear();
int[] ArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] ProductPairsNumbers(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] newArray = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
        }
        return newArray;
    }
    else
    {
        int[] newArray = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
        }
        newArray[newArray.Length - 1] = array[array.Length / 2];
        return newArray;
    }
}
int[] arrayRnd = ArrayRnd(9, 1, 8);
PrintArray(arrayRnd);
int[] productPairsNumbers = ProductPairsNumbers(arrayRnd);
Console.Write(" -> ");
PrintArray(productPairsNumbers);
Console.WriteLine();














